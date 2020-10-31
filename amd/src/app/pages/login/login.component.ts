import { GlobalService } from './../../global.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { StatusType, UserType } from 'app/models/models';
import { LoginService } from 'app/services/login.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  name;
  password;

  initDate: Date = new Date();

  constructor(private toastr: ToastrService,
    private loginService: LoginService,
    private router: Router,
    private globalService: GlobalService) { }

  ngOnInit() {
    this.globalService.username = null;
    window.localStorage.clear();
  }

  login(event) {
    if (this.name == null || this.name == '') {
      this.toastr.warning('Warning', 'Name is required');
    } else if (this.password == null || this.password == '') {
      this.toastr.warning('Warning', 'Password is required');
    } else {
      let body = {
        name: this.name,
        password: this.password,
      };
      this.loginService.Login(body).subscribe(
        item => {
          if (item && item.status == StatusType.Success) {
            this.globalService.username = item.data.name;
            this.loginService.setStorage(item);
            this.toastr.success('Success', 'Logged in successfully');
            if (item.data.type == UserType.Admin) {
              this.router.navigate(['/dashboard']);
            } else {
              this.router.navigate(['/dashboard']);
            }
          } else {
            if (item && item.errors && item.errors.length > 0) {
              for (let i = 0 ; i < item.errors.length ; i++) {
                this.toastr.error('', item.errors[i]);
              }
            }
          }
        }, err => {
          this.toastr.error('', 'Something went wrong, contact Admin');
        }
      )
    }
  }

  ngOnDestroy() {
    this.name = null;
    this.password = null;
  }

}
