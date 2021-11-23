import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mesa',
  templateUrl: './mesa.component.html',
  styleUrls: ['./mesa.component.scss']
})
export class MesaComponent implements OnInit {
  mesaEditId:number|null=null;
  editing=false;
  mesaData = {};
  mesas = [
    {nombre:'ventana',id:1},
    {nombre:'cocina',id:2}

  ];
  

  constructor() { }

  ngOnInit(): void {
  }

  
  inicioNuevo(){
    this.editing = true;
    this.mesaEditId = null;
    this.mesaData = {};
  }

  inicioEdit(id:number){
    console.log("esto id "+id)
    this.editing = true;
    this.mesaEditId = id;
    this.mesaData = this.getDataPorId(id);
  }

  getDataPorId(id:number){
    return {id:id}
  }

  guardar(){
    this.editing = false;
    location.reload();
  }

}
