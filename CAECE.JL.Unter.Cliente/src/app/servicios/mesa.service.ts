import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Mesa, Sector } from '../modelos/mesa.model';

@Injectable({
  providedIn: 'root'
})
export class MesaService {

    /* TODO: Remover lo de abajo cuando este integrado Hasta aca */
  sectoresIniciales: Sector[] =  [
    {nombre:'ventana',descripcion:'ventana',id:1},
    {nombre:'cocina',descripcion:null,id:2}
  ];
  mesasIniciales: Mesa[] =  [
    {
      id:1, nombre:'Mesa1',descripcion:'ventana',
      cantComensales:1, sector: this.sectoresIniciales.find(s => s.id==1)??new Sector()
    },
    {
      id:2, nombre:'Mesa2',descripcion:null,
      cantComensales:1,sector: this.sectoresIniciales.find(s => s.id==2)??new Sector()
    }
  ];

    /* TODO: Remover lo de arriba cuando este integrado Hasta aca */

    constructor(private httpClient: HttpClient) {
      // httpClient.get('').
    }
  

  public actualizarMesa(nuevosDatos:Mesa): Promise<Mesa|null>{
    if(nuevosDatos?.id == null ){
      return Promise.resolve(null); 
    }
    let mesaInd = this.mesasIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( mesaInd == -1 ){
      return Promise.resolve(null); 
    }
    this.mesasIniciales[mesaInd]=nuevosDatos;
    return Promise.resolve(nuevosDatos);
  }

  public obtenerTodos(): Promise<Mesa[]>{
    return Promise.resolve(this.mesasIniciales);
  }

  public obtenerMesa(mesaId:number|null): Promise<Mesa|null> {
    if(mesaId == null ){
      return Promise.resolve(null);
    }
    const mesa = this.mesasIniciales.find(m=>m.id == mesaId);
    return Promise.resolve(mesa==null?null: new Mesa(mesa));
  }

  public borrarMesa(mesaId:number):Promise<void>{  
    if( mesaId == null ){
      return Promise.resolve(); 
    }
    this.mesasIniciales = this.mesasIniciales.filter(m=>m.id != mesaId);
    return Promise.resolve();
  }

  public crearMesa(nuevosDatos:Mesa): Promise<Mesa|null> {
    if(nuevosDatos == null ){
      return Promise.resolve(null); 
    }
    nuevosDatos.id = this.mesasIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.mesasIniciales = this.mesasIniciales.concat(nuevosDatos);
    return Promise.resolve(nuevosDatos);
  }

  public obtenerSectores(): Promise<Sector[]> {
    return Promise.resolve(this.sectoresIniciales);
  }
  
  public obtenerSectorPorId(id:number|null): Promise<Sector|null> {
    let sector = this.sectoresIniciales.find(s => s.id == id);
    return Promise.resolve(sector==null?null:sector);
  }
}
