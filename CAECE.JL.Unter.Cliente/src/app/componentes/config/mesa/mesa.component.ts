import { Component, OnInit } from '@angular/core';
import { Mesa } from 'src/app/modelos/mesa.model';
import { MesaService } from 'src/app/servicios/mesa.service';

@Component({
  selector: 'app-mesa',
  templateUrl: './mesa.component.html',
  styleUrls: ['./mesa.component.scss']
})
export class MesaComponent implements OnInit {
  mesaEditId:number|null=null;
  editing=false;
  mesaData:Mesa = new Mesa();
  

  constructor(private mesaService:MesaService) { }

  ngOnInit(): void {
  }

  
  inicioNuevo(){
    this.editing = true;
    this.mesaEditId = null;
    this.mesaData = new Mesa();
  }

  inicioEdit(id:number|null){
    console.log("esto id "+id)
    this.editing = true;
    this.mesaEditId = id;
    this.mesaData = this.obtenerMesaPorId(id)?? new Mesa();
  }


  obtenerMesaPorId(id:number|null): Mesa |null{
    let item =this.mesaService.obtenerMesa(id)??new Mesa();
    return {...item};
  }

  obtenerMesas(): Mesa[]{
    return this.mesaService.obtenerTodos();
  }

  guardar(){
    this.editing = false;
    if(this.mesaData?.id==null){
    this.mesaService.crearMesa(this.mesaData);
  }else {
    this.mesaService.actualizarMesa(this.mesaData);
  }

    this.mesaData = new Mesa();
  }

}
