import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Mozo } from 'src/app/modelos/mozo.model';
import { MozoService } from 'src/app/servicios/mozo.service';


@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  mozoEditId:number|null=null;
  editing=false;
  mozoData:Mozo =new Mozo();


  constructor(private mozoService: MozoService, private route:Router) { }

  ngOnInit(): void {
  }

  inicioNuevo(){
    this.editing = true;
    this.mozoEditId = null;
    this.mozoData =  new Mozo();
  }

  inicioEdit(id:number|null){
    this.editing = true;
    this.mozoEditId = id;
    this.mozoData = this.obtenerMozoPorId(id) ?? new Mozo();
  }

  obtenerMozoPorId(id:number|null): Mozo |null{
    let item =this.mozoService.obtenerMozo(id)??new Mozo();
    return {...item};
  }

  obtenerMozos(): Mozo[]{
    return this.mozoService.obtenerTodos();
  }

  guardar(){
    this.editing = false;
    if(this.mozoData?.id==null){
    this.mozoService.crearMozo(this.mozoData);
  }else {
    this.mozoService.actualizarMozo(this.mozoData);
  }

    this.mozoData = new Mozo();
  }

 

}
