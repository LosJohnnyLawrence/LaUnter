import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Bebida, Categoria, Ingrediente, Item, Plato, RestriccionAlimentaria } from '../modelos/item.model';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  
  /* TODO: Remover lo de abajo cuando este integrado Hasta aca */
  restriccionesIniciales: RestriccionAlimentaria[] = [
    { id: 1, descripcion: 'apto diabeticos', nombre: 'diabeticos' },
    { id: 2, descripcion: 'apto celiaco', nombre: 'celiaco' },

  ];
  categoriasIniciales: Categoria[] = [
    { id: 1, descripcion: 'gaseosa', nombre: 'gaseosa' },
    { id: 2, descripcion: 'aguas', nombre: 'aguas' },
    { id: 3, descripcion: 'sanguches', nombre: 'sanguches' }
  ];
  ingredientesIniciales: Ingrediente[] = [
    {
      id: 5, nombre: 'pan', descripcion: 'pan',
      precio: 22.09, componentes: [], costo: 1, cantidadStock: 5
    },
    {
      id: 6, nombre: 'salame', descripcion: 'salame',
      precio: 22.09, componentes: [], costo: 1, cantidadStock: 5
    },
    {
      id: 7, nombre: 'milanesa', descripcion: 'milanesa',
      precio: 22.09, componentes: [], costo: 1, cantidadStock: 5
    },
    {
      id: 8, nombre: 'queso', descripcion: 'queso',
      precio: 22.09, componentes: [], costo: 1, cantidadStock: 5
    },
    {
      id: 9, nombre: 'jamon', descripcion: 'jamon',
      precio: 22.09, componentes: [], costo: 1, cantidadStock: 5
    },
  ];

  bebidasIniciales: Bebida[] = [
    {
      id: 1, nombre: 'coca', descripcion: 'coca',
      precio: 10.09, componentes: [], categoria: this.categoriasIniciales.find(c => c.id == 1) ?? new Categoria(),
      restriccionesAlimentarias: [],
    },
    {
      id: 2, nombre: 'agua', descripcion: 'agua',
      precio: 22.09, componentes: [], categoria: this.categoriasIniciales.find(c => c.id == 2) ?? new Categoria(),
      restriccionesAlimentarias: [{ id: 1, descripcion: 'apto diabeticos', nombre: 'diabeticos' }],
    },
  ];

  platosIniciales: Plato[] = [
    {
      id: 3, nombre: 'picada grande', descripcion: 'picada grande',
      precio: 10.09, componentes: this.ingredientesIniciales.filter(i => [9, 8].includes(i.id ?? -1)),
      categoria: { id: 3, descripcion: 'picadas', nombre: 'picadas' },
      restriccionesAlimentarias: [], posiblesExtras: this.ingredientesIniciales.filter(i => [7].includes(i.id ?? -1))
    },
    {
      id: 4, nombre: 'sanguche', descripcion: 'sanguche',
      precio: 22.09, componentes:
        this.ingredientesIniciales.filter(i => [5, 6].includes(i.id ?? -1)),
      categoria: this.categoriasIniciales.find(c => c.id == 3) ?? new Categoria(),
      restriccionesAlimentarias: this.restriccionesIniciales.filter(c => c.id == 1),
      posiblesExtras: this.ingredientesIniciales.filter(i => [9, 8].includes(i.id ?? -1))
    },
  ];

  /* TODO: Remover lo de arriba cuando este integrado Hasta aca */

  constructor(private httpClient: HttpClient) {
    // httpClient.get('').
  }

  public actualizarPlato(nuevosDatos: Plato): Promise<Plato | null> {
    if (nuevosDatos?.id == null) {
      return Promise.resolve(null);
    }
    let platoInd = this.platosIniciales.findIndex(m => m.id == nuevosDatos.id);
    if (platoInd == -1) {
      return Promise.resolve(null);
    }
    this.platosIniciales[platoInd] = nuevosDatos;
    return Promise.resolve(nuevosDatos);
  }

  public obtenerPlatos(): Promise<Plato[]> {
    return Promise.resolve(this.platosIniciales);
  }

  public obtenerRestricciones(): Promise<RestriccionAlimentaria[]> {
    return Promise.resolve(this.restriccionesIniciales);
  }
  public obtenerCategorias(): Promise<Categoria[]> {
    return Promise.resolve(this.categoriasIniciales);
  }

  public obtenerPlato(platoId: number | null): Promise<Plato | null> {
    if (platoId == null) {
      return Promise.resolve(null);
    }
    const plato = this.platosIniciales.find(m => m.id == platoId);
    return Promise.resolve(plato == null ? null : Plato.clonar(plato));
  }

  public borrarPlato(platoId: number): Promise<void> {
    if (platoId == null) {
      return Promise.resolve();
    }
    this.platosIniciales = this.platosIniciales.filter(m => m.id != platoId)
    return Promise.resolve();
  }

  public crearPlato(nuevosDatos: Plato): Promise<Plato | null> {
    if (nuevosDatos == null) {
      return Promise.resolve(null);
    }
    nuevosDatos.id = this.platosIniciales.reduce((acc, curr) => (acc < (curr?.id ?? 0) ? curr?.id ?? 0 : acc), 1) + 1;
    this.platosIniciales = this.platosIniciales.concat(nuevosDatos);
    return Promise.resolve(nuevosDatos);
  }

  public actualizarBebida(nuevosDatos: Bebida): Promise<Bebida | null> {
    if (nuevosDatos?.id == null) {
      return Promise.resolve(null);
    }
    let bebidaInd = this.bebidasIniciales.findIndex(m => m.id == nuevosDatos.id);
    if (bebidaInd == -1) {
      return Promise.resolve(null);
    }
    this.bebidasIniciales[bebidaInd] = nuevosDatos;
    return Promise.resolve(nuevosDatos);
  }

  public obtenerBebidas(): Promise<Bebida[]> {
    return Promise.resolve(this.bebidasIniciales);
  }

  public obtenerBebida(bebidaId: number | null): Promise<Bebida | null> {
    if (bebidaId == null) {
      return Promise.resolve(null);
    }
    const bebida = this.bebidasIniciales.find(m => m.id == bebidaId);
    return Promise.resolve(bebida == null ? null : Bebida.clonar(bebida));
  }

  public borrarBebida(bebidaId: number): Promise<void> {
    if (bebidaId == null) {
      return Promise.resolve();
    }
    this.bebidasIniciales = this.bebidasIniciales.filter(m => m.id != bebidaId);
    return Promise.resolve();
  }

  public crearBebida(nuevosDatos: Bebida): Promise<Bebida | null> {
    if (nuevosDatos == null) {
      return Promise.resolve(null);
    }
    nuevosDatos.id = this.bebidasIniciales.reduce((acc, curr) => (acc < (curr?.id ?? 0) ? curr?.id ?? 0 : acc), 1) + 1;
    this.bebidasIniciales = this.bebidasIniciales.concat(nuevosDatos);
    return Promise.resolve(nuevosDatos);
  }


  public actualizarIngrediente(nuevosDatos: Ingrediente): Promise<Ingrediente | null> {
    if (nuevosDatos?.id == null) {
      return Promise.resolve(null);
    }
    let ingredienteInd = this.ingredientesIniciales.findIndex(m => m.id == nuevosDatos.id);
    if (ingredienteInd == -1) {
      return Promise.resolve(null);
    }
    this.ingredientesIniciales[ingredienteInd] = nuevosDatos;
    return Promise.resolve(nuevosDatos);
  }

  public obtenerIngredientes(): Promise<Ingrediente[]> {
    return Promise.resolve(this.ingredientesIniciales);
  }

  public obtenerIngrediente(ingredienteId: number | null): Promise<Ingrediente | null> {
    if (ingredienteId == null) {
      return Promise.resolve(null);
    }
    const ingrediente = this.ingredientesIniciales.find(m => m.id == ingredienteId);
    return Promise.resolve(ingrediente == null ? null : Ingrediente.clonar(ingrediente));
  }

  public borrarIngrediente(ingredienteId: number): Promise<void> {
    if (ingredienteId == null) {
      return Promise.resolve();
    }
    this.ingredientesIniciales = this.ingredientesIniciales.filter(m => m.id != ingredienteId)
    return Promise.resolve();
  }

  public crearIngrediente(nuevosDatos: Ingrediente): Promise<Ingrediente | null> {
    if (nuevosDatos == null) {
      return Promise.resolve(null);
    }
    nuevosDatos.id = this.ingredientesIniciales.reduce((acc, curr) => (acc < (curr?.id ?? 0) ? curr?.id ?? 0 : acc), 1) + 1;
    this.ingredientesIniciales = this.ingredientesIniciales.concat(nuevosDatos);
    return Promise.resolve(nuevosDatos);
  }
}
