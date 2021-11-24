import { Injectable } from '@angular/core';
import { Mozo } from '../modelos/mozo.model';

@Injectable({
  providedIn: 'root'
})
export class MozoService {
  mozosIniciales: Mozo[] = [
    { nombre: 'fafa', DNI:'123', id: 1, turnos: [{ sector: 1, dia: 2, entrada: '11:32', salida: '15:00' }] },
    { nombre: 'lala', DNI:'123', id: 2, turnos:[] },
    {
      nombre: 'tata', DNI:'123', id: 9, turnos: [
        { sector: 1, dia: 2, entrada: '11:32', salida: '15:00' },
        { sector: 1, dia: 3, entrada: '11:32', salida: '15:00' },
      ]
    }

  ];
  constructor() { }

  public actualizarMozo(nuevosDatos:Mozo): Mozo | null{
    if(nuevosDatos?.id == null ){
      return null; 
    }
    let mozoInd = this.mozosIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( mozoInd == -1 ){
      return null; 
    }
    this.mozosIniciales[mozoInd]=nuevosDatos;
    return nuevosDatos;
  }

  public obtenerTodos(): Mozo[]{
    return this.mozosIniciales;
  }

  public obtenerMozo(mozoId:number|null): Mozo | null{
    if(mozoId == null ){
      return null; 
    }
    return this.mozosIniciales.find(m=>m.id == mozoId)??null;
  }

  public borrarMozo(mozoId:number){  
    if( mozoId == null ){
      return; 
    }
    this.mozosIniciales = this.mozosIniciales.filter(m=>m.id != mozoId)
  }

  public crearMozo(nuevosDatos:Mozo): Mozo|null {
    if(nuevosDatos == null ){
      return null; 
    }
    nuevosDatos.id = this.mozosIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.mozosIniciales = this.mozosIniciales.concat(nuevosDatos);
    return nuevosDatos;
  }
}
