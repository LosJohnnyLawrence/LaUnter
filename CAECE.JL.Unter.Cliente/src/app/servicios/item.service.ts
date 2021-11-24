import { Injectable } from '@angular/core';
import { Bebida, Ingrediente, Item, Plato } from '../modelos/item.model';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
/* TODO: Remover lo de abajo cuando este integrado Hasta aca */
  ingredientesIniciales: Ingrediente[] =  [
    { 
      id: 5,nombre: 'pan',descripcion: 'pan',
      precio: 22.09, componentes: [], costo:1,CantidadStock:5
    },
    { 
      id: 6,nombre: 'salame',descripcion: 'salame',
      precio: 22.09, componentes: [], costo:1,CantidadStock:5
    },
    { 
      id: 7,nombre: 'milanesa',descripcion: 'milanesa',
      precio: 22.09, componentes: [], costo:1,CantidadStock:5
    },
    { 
      id: 8,nombre: 'queso',descripcion: 'queso',
      precio: 22.09, componentes: [], costo:1,CantidadStock:5
    },
    { 
      id: 9,nombre: 'jamon',descripcion: 'jamon',
      precio: 22.09, componentes: [], costo:1,CantidadStock:5
    },
    ];
    
  bebidasIniciales: Bebida[] =  [
    { 
      id: 1,nombre: 'coca',descripcion: 'coca',
      precio: 10.09, componentes: [],categoria: {id:1, descripcion:'gaseosa',nombre:'gaseosa'},
      restriccionesAlimentarias: [],
    },
    { 
      id: 2,nombre: 'agua',descripcion: 'agua',
      precio: 22.09, componentes: [],categoria: {id:2, descripcion:'aguas',nombre:'aguas'},
      restriccionesAlimentarias: [{id: 1, descripcion:'apto diabeticos',nombre:'diabeticos' }],
    },    
  ];

platosIniciales: Plato[] =  [
  { 
    id: 3,nombre: 'picada grande',descripcion: 'picada grande',
    precio: 10.09, componentes: this.ingredientesIniciales.filter(i => [9,8].includes(i.id??-1)),
    categoria: {id:3, descripcion:'picadas',nombre:'picadas'},
    restriccionesAlimentarias: [], posiblesExtras:this.ingredientesIniciales.filter(i => [7].includes(i.id??-1))
  },
  { 
    id: 4,nombre: 'sanguche',descripcion: 'sanguche',
    precio: 22.09, componentes: 
      this.ingredientesIniciales.filter(i => [5,6].includes(i.id??-1)),
    categoria: {id:1, descripcion:'',nombre:''},
    restriccionesAlimentarias: [{id: 1, descripcion:'apto diabeticos',nombre:'diabeticos' }],
    posiblesExtras:this.ingredientesIniciales.filter(i => [9,8].includes(i.id??-1))
  },
  ];
/* TODO: Remover lo de arriba cuando este integrado Hasta aca */
  constructor() { }

  public actualizarPlato(nuevosDatos:Plato): Plato | null{
    if(nuevosDatos?.id == null ){
      return null; 
    }
    let platoInd = this.platosIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( platoInd == -1 ){
      return null; 
    }
    this.platosIniciales[platoInd]=nuevosDatos;
    return nuevosDatos;
  }

  public obtenerPlatos(): Plato[]{
    return this.platosIniciales;
  }

  public obtenerPlato(platoId:number|null): Plato | null{
    if(platoId == null ){
      return null; 
    }
    return this.platosIniciales.find(m=>m.id == platoId)??null;
  }

  public borrarPlato(platoId:number){  
    if( platoId == null ){
      return; 
    }
    this.platosIniciales = this.platosIniciales.filter(m=>m.id != platoId)
  }

  public crearPlato(nuevosDatos:Plato): Plato|null {
    if(nuevosDatos == null ){
      return null; 
    }
    nuevosDatos.id = this.platosIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.platosIniciales = this.platosIniciales.concat(nuevosDatos);
    return nuevosDatos;
  }

  public actualizarBebida(nuevosDatos:Bebida): Bebida | null{
    if(nuevosDatos?.id == null ){
      return null; 
    }
    let bebidaInd = this.bebidasIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( bebidaInd == -1 ){
      return null; 
    }
    this.bebidasIniciales[bebidaInd]=nuevosDatos;
    return nuevosDatos;
  }

  public obtenerBebidas(): Bebida[]{
    return this.bebidasIniciales;
  }

  public obtenerBebida(bebidaId:number|null): Bebida | null{
    if(bebidaId == null ){
      return null; 
    }
    return this.bebidasIniciales.find(m=>m.id == bebidaId)??null;
  }

  public borrarBebida(bebidaId:number){  
    if( bebidaId == null ){
      return; 
    }
    this.bebidasIniciales = this.bebidasIniciales.filter(m=>m.id != bebidaId)
  }

  public crearBebida(nuevosDatos:Bebida): Bebida|null {
    if(nuevosDatos == null ){
      return null; 
    }
    nuevosDatos.id = this.bebidasIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.bebidasIniciales = this.bebidasIniciales.concat(nuevosDatos);
    return nuevosDatos;
  }


  public actualizarIngrediente(nuevosDatos:Ingrediente): Ingrediente | null{
    if(nuevosDatos?.id == null ){
      return null; 
    }
    let ingredienteInd = this.ingredientesIniciales.findIndex(m=>m.id == nuevosDatos.id);
    if( ingredienteInd == -1 ){
      return null; 
    }
    this.ingredientesIniciales[ingredienteInd]=nuevosDatos;
    return nuevosDatos;
  }

  public obtenerIngredientes(): Ingrediente[]{
    return this.ingredientesIniciales;
  }

  public obtenerIngrediente(ingredienteId:number|null): Ingrediente | null{
    if(ingredienteId == null ){
      return null; 
    }
    return this.ingredientesIniciales.find(m=>m.id == ingredienteId)??null;
  }

  public borrarIngrediente(ingredienteId:number){  
    if( ingredienteId == null ){
      return; 
    }
    this.ingredientesIniciales = this.ingredientesIniciales.filter(m=>m.id != ingredienteId)
  }

  public crearIngrediente(nuevosDatos:Ingrediente): Ingrediente|null {
    if(nuevosDatos == null ){
      return null; 
    }
    nuevosDatos.id = this.ingredientesIniciales.reduce((acc,curr)=>(acc<(curr?.id??0)?curr?.id??0:acc),1)+1;
    this.ingredientesIniciales = this.ingredientesIniciales.concat(nuevosDatos);
    return nuevosDatos;
  }
}
