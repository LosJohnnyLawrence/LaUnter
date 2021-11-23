import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  mozoEditId:number|null=null;
  editing=false;
  mozoData = {};
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
    this.mozoData = {};
  }

  inicioEdit(id:number){
    console.log("esto id "+id)
    this.editing = true;
    this.mozoEditId = id;
    this.mozoData = this.getDataPorId(id);
  }

  getDataPorId(id:number){
    return {id:id}
  }

  guardar(){
    this.editing = false;
    location.reload();
  }

 

}
