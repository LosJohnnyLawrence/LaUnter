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

  listaMozos: Mozo[] = new Array<Mozo>();
  listaDias: {nombre:string, numero:number}[] = new Array<{nombre:string, numero:number}>();
  editing=false;
  mozoData:Mozo =new Mozo();


  constructor(private mozoService: MozoService, private route:Router) { 
    
  }

  ngOnInit(): void {
    this.actualizarMozos();
  }

  actualizarMozos() {
    this.listaDias = this.mozoService.obtenerDias();
    this.mozoService.obtenerTodos().then(m=>this.listaMozos=m);
  }

  inicioNuevo(){
    this.editing = true;
    this.mozoData =  new Mozo();
  }

  inicioEdit(mozo:Mozo|null){
    this.editing = true;
    const id = mozo?.id??-1;
    this.mozoService.obtenerMozo(id).then(m=>this.mozoData= m??new Mozo());
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

  borrarMozo(mozo:Mozo|null){
    if(confirm("Seguro que queres borrar "+ mozo?.nombre??""+"?")) {
    this.mozoService.borrarMozo(mozo?.id??-1).then(_=>this.actualizarMozos());
    }
  } 

}
