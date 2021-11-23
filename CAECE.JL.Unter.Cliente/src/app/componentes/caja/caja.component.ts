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
    const dialogoRef = this.dialog.open(DialogoAccionComponent, {
      data: fila,   
  });
  dialogoRef.afterClosed().subscribe(result => {
    console.log('The dialog was closed');
    console.log(result);
  });
}

}
