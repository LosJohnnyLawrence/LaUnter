import { Component, Inject, OnInit } from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';
@Component({
  selector: 'app-dialogo-accion',
  templateUrl: './dialogo-accion.component.html',
  styleUrls: ['./dialogo-accion.component.scss']
})
export class DialogoAccionComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit(): void {
  }

}
