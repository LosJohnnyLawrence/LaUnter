import { Component, OnInit } from '@angular/core';

class Turno {
public sector:number|null=null;
public dia:number|null=null;
public entrada:string|null=null;
public salida:string|null=null;
}
class Mozo {
  public id:number|null|undefined;
  public nombre:string|null|undefined;
  public  turnos:Turno[]|null|undefined;
  }

@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  mozoEditId:number|null=null;
  editing=false;
  mozoData:Mozo =
   {nombre:null,id:null,turnos:[]};
  mozos = [
    {nombre:'fafa',id:1,turnos:[{sector:1,dia:2,entrada:'11:32',salida:'15:00'}]},
    {nombre:'lala',id:2},
    {nombre:'tata',id:9,turnos:[
      {sector:1,dia:2,entrada:'11:32',salida:'15:00'},
      {sector:1,dia:3,entrada:'11:32',salida:'15:00'},
    ]}

  ];

  constructor() { }

  ngOnInit(): void {
  }

  inicioNuevo(){
    this.editing = true;
    this.mozoEditId = null;
    this.mozoData=  {nombre:null,id:null,turnos:[]};
  }

  inicioEdit(id:number){
    console.log("esto id "+id)
    this.editing = true;
    this.mozoEditId = id;
    this.mozoData = this.getDataPorId(id);
  }

  getDataPorId(id:number): Mozo{
    let mozoActual = this.mozos.find(m=>m.id==id);
    return {id:id, nombre: mozoActual?.nombre,turnos:mozoActual?.turnos}
  }

  guardar(){
    this.editing = false;
    location.reload();
  }

 

}
