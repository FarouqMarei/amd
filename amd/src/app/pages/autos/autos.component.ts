import { AutoService } from './../services/auto.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Table } from 'primeng/table';
import { NgxSpinnerService } from "ngx-spinner";

@Component({
  selector: 'app-autos',
  templateUrl: './autos.component.html',
  styleUrls: ['./autos.component.scss']
})
export class AutosComponent implements OnInit {

  autos: any[];

  cols: any[];
  selectedAutos: any[];

  @ViewChild('dt') table: Table;

  showDialog = false;

  constructor(private autoService: AutoService,
    private spinner: NgxSpinnerService) { }

  ngOnInit() {
    this.spinner.show();
    const userId = localStorage.getItem('userId');
    this.autoService.getAllByUser(parseInt(userId)).subscribe(res => {
      this.autos = res.data;
      this.spinner.hide();
    }, err => {
      this.spinner.hide();
    });

    this.cols = [
      { field: 'id', header: 'Id', hidden: true },
      { field: 'name', header: 'Name' },
      { field: 'brandName', header: 'Brand' },
      { field: 'color', header: 'Color' },
      { field: 'loadPortName', header: 'Load Port' },
      { field: 'buyerName', header: 'Buyer' },
      { field: 'cityName', header: 'City' },
      { field: 'destinationName', header: 'Destination' },
      { field: 'containerSerial', header: 'Container' },
      { field: 'displayStatusStr', header: 'Display Status' },
      { field: 'paperStatusStr', header: 'Paper Status' },
      { field: 'carStatusStr', header: 'Car Status' }
    ];
  }

  filterGlobal(evt) {

  }

  editRow(row) {

  }

  deleteRows() {
  }

  openNew() {
    this.showDialog = true;
  }

  hideDialog() {
    this.showDialog = false;
  }

  saveAuto() {

  }

}
