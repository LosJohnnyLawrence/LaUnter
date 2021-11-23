import { Component, Inject, OnInit } from '@angular/core';
import {MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
@Component({
  selector: 'app-dialogo-accion',
  templateUrl: './dialogo-accion.component.html',
  styleUrls: ['./dialogo-accion.component.scss']
})
export class DialogoAccionComponent implements OnInit {

  constructor( public dialogRef: MatDialogRef<DialogoAccionComponent>,@Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit(): void {
  }
  cerrar(){this.dialogRef.close();}

}
