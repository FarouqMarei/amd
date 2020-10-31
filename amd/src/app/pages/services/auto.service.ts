import { Injectable } from '@angular/core';
import { ResponseResult } from 'app/models/models';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AutoService {

  apiUrl = 'https://localhost:44334/api/autos';

  constructor(private http: HttpClient, private router: Router) { }

  getAllByUser(id): Observable<ResponseResult<any>> {
    const url = this.apiUrl + '/getAllByUser/' + id;
    return this.http.get<ResponseResult<any>>(url);
  }

}
