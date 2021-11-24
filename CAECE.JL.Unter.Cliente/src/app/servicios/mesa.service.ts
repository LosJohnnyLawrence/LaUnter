import { Injectable } from '@angular/core';
import { Mesa } from '../modelos/mesa.model';

@Injectable({
  providedIn: 'root'
})
export class MesaService {

  mesasIniciales: Mesa[] =  [
    {nombre:'ventana',descripcion:'ventana',id:1, cantComensales:1,sectorId:1},
    {nombre:'cocina',descripcion:null,id:2, cantComensales:1,sectorId:2}
  ];
  constructor() { }

  public actualizarMesa(nuevosDatos:Mesa): Mesa | null{
    if(nuevosDatos?.id == null ){
      return null; 
    }
    let mesaInd = this.mesasIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( mesaInd == -1 ){
      return null; 
    }
    this.mesasIniciales[mesaInd]=nuevosDatos;
    return nuevosDatos;
  }

  public obtenerTodos(): Mesa[]{
    return this.mesasIniciales;
  }

  public obtenerMesa(mesaId:number|null): Mesa | null{
    if(mesaId == null ){
      return null; 
    }
    return this.mesasIniciales.find(m=>m.id == mesaId)??null;
  }

  public borrarMesa(mesaId:number){  
    if( mesaId == null ){
      return; 
    }
    this.mesasIniciales = this.mesasIniciales.filter(m=>m.id != mesaId)
  }

  public crearMesa(nuevosDatos:Mesa): Mesa|null {
    if(nuevosDatos == null ){
      return null; 
    }
    nuevosDatos.id = this.mesasIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.mesasIniciales = this.mesasIniciales.concat(nuevosDatos);
    return nuevosDatos;
  }
}
