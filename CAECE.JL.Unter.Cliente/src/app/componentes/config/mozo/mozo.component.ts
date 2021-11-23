import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  mozoEditId:number|null=null;
  editing=false;
  mozoData:{id:number|null|undefined, nombre:string|null|undefined} = {nombre:null,id:null};
  mozos = [
    {nombre:'fafa',id:1},
    {nombre:'lala',id:2},
    {nombre:'tata',id:9}

  ];

  constructor() { }

  ngOnInit(): void {
  }

  inicioNuevo(){
    this.editing = true;
    this.mozoEditId = null;
    this.mozoData=  {nombre:null,id:null};
  }

  inicioEdit(id:number){
    console.log("esto id "+id)
    this.editing = true;
    this.mozoEditId = id;
    this.mozoData = this.getDataPorId(id);
  }

  getDataPorId(id:number): {id:number|null,nombre:string|null|undefined}{
    return {id:id, nombre: this.mozos.find(m=>m.id==id)?.nombre}
  }

  guardar(){
    this.editing = false;
    location.reload();
  }

 

}
