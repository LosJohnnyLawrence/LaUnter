import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogoAccionComponent } from './dialogo-accion/dialogo-accion.component';

@Component({
  selector: 'app-caja',
  templateUrl: './caja.component.html',
  styleUrls: ['./caja.component.scss']
})
export class CajaComponent implements OnInit {

  constructor(public dialog: MatDialog) { }
  dataSource=[{nombre:'dfdffd',direccion:'sdsd'}];
  displayedColumns: string[] = ['nombre','direccion'];
  ngOnInit(): void {
  }

  accionClick(fila:any){
    this.dialog.open(DialogoAccionComponent, {
      data: fila,   
  });
}

}
