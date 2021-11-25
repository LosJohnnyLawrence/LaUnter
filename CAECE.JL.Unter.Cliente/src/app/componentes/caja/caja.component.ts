import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { Estadia } from 'src/app/modelos/estadia.model';
import { Mesa } from 'src/app/modelos/mesa.model';
import { ItemService } from 'src/app/servicios/item.service';
import { MesaService } from 'src/app/servicios/mesa.service';
import { DialogoAccionComponent } from './dialogo-accion/dialogo-accion.component';

@Component({
  selector: 'app-caja',
  templateUrl: './caja.component.html',
  styleUrls: ['./caja.component.scss']
})
export class CajaComponent implements OnInit {

  constructor(public dialog: MatDialog, private mesaService:MesaService) { }
  dataSource= new MatTableDataSource<Mesa>();
  displayedColumns: string[] = ['mesa'];
  ngOnInit(): void {
    this.mesaService.obtenerTodos().then(m=>this.dataSource.data=m);
  }

  accionClick(fila:any){
    const dialogoRef = this.dialog.open(DialogoAccionComponent, {
      data: fila,   
  });
  dialogoRef.afterClosed().subscribe(result => {
    
  });
}

}
