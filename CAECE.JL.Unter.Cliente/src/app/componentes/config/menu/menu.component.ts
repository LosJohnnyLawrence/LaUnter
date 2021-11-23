import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  itemEditId:number|null=null;
  editing=false;
  itemData = {};
  items = [
    {nombre:'papa',id:1},
    {nombre:'pure',id:2}

  ];
  constructor() { }

  ngOnInit(): void {
  }

  
  inicioNuevo(){
    this.editing = true;
    this.itemEditId = null;
    this.itemData = {};
  }

  inicioEdit(id:number){
    console.log("esto id "+id)
    this.editing = true;
    this.itemEditId = id;
    this.itemData = this.getDataPorId(id);
  }

  getDataPorId(id:number){
    return {id:id}
  }

  guardar(){
    this.editing = false;
    location.reload();
  }

}
