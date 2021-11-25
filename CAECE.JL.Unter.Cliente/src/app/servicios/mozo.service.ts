import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Sector } from '../modelos/mesa.model';
import { Mozo } from '../modelos/mozo.model';
import { MesaService } from './mesa.service';

@Injectable({
  providedIn: 'root'
})
export class MozoService {

  sectoresIniciales:Sector[] = new Array<Sector>();

  constructor(private mesaService:MesaService, private httpClient: HttpClient) {
    this.mesaService.obtenerSectores().then(s=> this.sectoresIniciales=s);
   }

  
  mozosIniciales: Mozo[] = [
    { nombre: 'fafa', DNI:'123', id: 1, turnos: [{id:1, sector: this.sectoresIniciales.find(s=>s.id==1)??new Sector(), dia: 2, entrada: '11:32', salida: '15:00' }] },
    { nombre: 'lala', DNI:'123', id: 2, turnos:[] },
    {
      nombre: 'tata', DNI:'123', id: 9, turnos: [
        { id:2,sector: this.sectoresIniciales.find(s=>s.id==1)??new Sector(), dia: 2, entrada: '11:32', salida: '15:00' },
        { id:3,sector: this.sectoresIniciales.find(s=>s.id==1)??new Sector(), dia: 3, entrada: '11:32', salida: '15:00' },
      ]
    }

  ];
 

  public actualizarMozo(nuevosDatos:Mozo): Promise<Mozo|null> {
    if(nuevosDatos?.id == null ){
      return Promise.resolve(null); 
    }
    let mozoInd = this.mozosIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( mozoInd == -1 ){
      return Promise.resolve(null); 
    }
    this.mozosIniciales[mozoInd]=nuevosDatos;
    return Promise.resolve(nuevosDatos);
  }

  public obtenerTodos(): Promise<Mozo[]>{
    return Promise.resolve(this.mozosIniciales);
  }

  public obtenerDias(): {nombre:string, numero:number}[]{
    return [ 
      {nombre:'domingo', numero:1},
      {nombre:'lunes', numero:2},
      {nombre:'martes', numero:3},
      {nombre:'miercoles', numero:4},
      {nombre:'jueves', numero:5},
      {nombre:'viernes', numero:6},
      {nombre:'sabado', numero:7},
    ]
  }

  public obtenerMozo(mozoId:number|null): Promise<Mozo|null> {
    if(mozoId == null ){
      return Promise.resolve(null); 
    }
    let mozo = this.mozosIniciales.find(m=>m.id == mozoId);
    return Promise.resolve(mozo==null?null:new Mozo(mozo));
  }

  

  public borrarMozo(mozoId:number): Promise<void> {  
    if( mozoId == null ){
      return Promise.resolve(); 
    }
    this.mozosIniciales = this.mozosIniciales.filter(m=>m.id != mozoId);
    return Promise.resolve();
  }

  public crearMozo(nuevosDatos:Mozo): Promise<Mozo|null> {
    if(nuevosDatos == null ){
      return Promise.resolve(null); 
    }
    nuevosDatos.id = this.mozosIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.mozosIniciales = this.mozosIniciales.concat(nuevosDatos);
    return Promise.resolve(nuevosDatos);
  }
}
