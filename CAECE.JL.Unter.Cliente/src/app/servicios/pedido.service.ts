import { HttpClient } from '@angular/common/http';
import { ArrayType } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Estadia } from '../modelos/estadia.model';
import { Item } from '../modelos/item.model';
import { Mesa, Sector } from '../modelos/mesa.model';
import { Mozo } from '../modelos/mozo.model';
import { Cliente, EstadoPreparacion, Pedido, Seleccion } from '../modelos/pedido.model';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {

  /* TODO: Remover lo de abajo cuando este integrado Hasta aca */
  estadosIniciales: EstadoPreparacion[] =  [
    {nombre:'Tomando',descripcion:'Tomando Pedido',id:1},
    {nombre:'Preparacion',descripcion:'En Preparacion',id:2},
    {nombre:'Listo',descripcion:'Listo para entregar',id:3},
    {nombre:'Entregado',descripcion:'Ya Entregado',id:4},
    {nombre:'Cancelado',descripcion:'Cancelado',id:5},
    {nombre:'Devolucion',descripcion:'Devuelto',id:6}
  ];

pedidosIniciales: Pedido[] =  [
 {notas:'adads',nombre:'sdsd',id:1, mesa:new Mesa({id:1,nombre:'',descripcion:'',sector:new Sector(),cantComensales:1,estado:null}),
 cliente: new Cliente(), mozo: new Mozo(),
 estado: this.estadosIniciales.find(e=>e.nombre=="Listo")??new EstadoPreparacion(),
 seleccions:[{item:new Item(),id:1, cantidad:2, agregar:new Array<Item>(),
  sacar:new Array<Item>(),estado:this.estadosIniciales.find(e=>e.nombre=="Listo")??new EstadoPreparacion()
 }] }
];

estadiasIniciales: Estadia[] =  [
 { id:1, mesa:new Mesa(), fechaInicio:new Date(Date.now()),fechaFin:null,
  cliente: new Cliente(), mozo: new Mozo(),pedidos: [this.pedidosIniciales[0]?? new Pedido()]
 }
];




  /* TODO: Remover lo de arriba cuando este integrado Hasta aca */

constructor(private httpClient: HttpClient) { }


/**Nueva estadia */
public AbrirMesa(mesa:Mesa|null,cliente:Cliente|null,mozo:Mozo|null): Promise<Estadia> {
  
  return this.httpClient.post<Estadia>(environment.apiUrlBase+"/api/mesa/AbrirMesa",
    {mesaId:mesa?.id,cliente:cliente, mozoId: mozo?.id}).toPromise();
}

/**Cierra estadia */
public CerrarMesa(mesa:Mesa): Promise<Estadia|null> {
  return this.httpClient.post<Estadia>(environment.apiUrlBase+"/api/mesa/AbrirMesa",
  mesa).toPromise();
}




public AvanzarEstadoSeleccion(seleccion:Seleccion|null): Promise<Seleccion|null>  {

  return Promise.resolve(null);
}

public RetrocedeEstadoSeleccion(seleccion:Seleccion|null): Promise<Seleccion|null>  {

  return Promise.resolve(null);
}

public CancelearEstadoSeleccion(seleccion:Seleccion|null): Promise<Seleccion|null>  {

  return Promise.resolve(null);
}

public AvanzarEstadoPedido(pedido:Pedido|null): Promise<Pedido|null>  {

  return Promise.resolve(null);
}

public RetrocedeEstadoPedido(pedido:Pedido|null): Promise<Pedido|null>  {

  return Promise.resolve(null);
}

public CancelearEstadoPedido(pedido:Pedido|null): Promise<Pedido|null>  {

  return Promise.resolve(null);
}

// public CambiarEstadoSeleccion(seleccion:Seleccion|null, estado:EstadoPreparacion): Promise<Seleccion|null>  {
//   if (seleccion == null || seleccion == null) {
//     return Promise.resolve(null);
//   }
//   for (let ped of this.pedidosIniciales) {
//     const sels = ped.seleccions;
//     for(let selInd in sels){
//     if (seleccion.id == sels[selInd].id) {
//       sels[selInd].estado = this.estadosIniciales.find(e=>estado.id==e.id)??estado;
//       return Promise.resolve(sels[selInd]);
//     }
//     }
//   }
//   return Promise.resolve(null);
// }

// public CambarEstadoPedido(pedido:Pedido|null, estado:EstadoPreparacion): Promise<Pedido|null> {
//   if (seleccion == null || pedido == null) {
//     return Promise.resolve(null);
//   }
//   for (let ped of this.pedidosIniciales) {
//     if (ped.id == pedido.id) {
//       ped.estado == this.estadosIniciales.find(e=>estado.id==e.id);
//       return Promise.resolve(ped);
//     }
//   }
//   return Promise.resolve(null);
// }

public ObetenerEstados(): Promise<EstadoPreparacion[]> {
  return Promise.resolve(this.estadosIniciales);
}
public ObtenerPedidos(): Promise<Pedido[]> {
  return Promise.resolve(this.pedidosIniciales);
}

public ObetenerEstadoPorId(estadoId: number): Promise<EstadoPreparacion|null> {
  const estado = this.estadosIniciales.find(e=>e.id==estadoId);
  return Promise.resolve(estado==null?null:estado);
}

public BorrarPedido(pedido:Pedido|null): Promise<void> {
  this.pedidosIniciales.filter(p => p.id == pedido?.id);
  return Promise.resolve();
}
public BorrarSeleccion(seleccion:Seleccion|null): Promise<void> {
  for(let ped of this.pedidosIniciales){
    ped.seleccions == ped.seleccions.filter(s=>s.id!=seleccion?.id);
    }
    return Promise.resolve();
}
public CrearPedido(pedido:Pedido|null): Promise<Pedido|null> {
  if(pedido==null){return Promise.resolve(null);}
  pedido.id = this.pedidosIniciales.reduce((max,ped)=>  ped?.id??0 >max? ped?.id??0 : max +1,0);
  this.pedidosIniciales.push(pedido);
  return Promise.resolve(pedido);
}
  public CrearSeleccion(seleccion: Seleccion | null, pedido: Pedido | null): Promise<Seleccion | null> {
    if (seleccion == null || pedido == null) {
      return Promise.resolve(null);
    }
    for (let ped of this.pedidosIniciales) {
      if (ped.id == pedido.id) {
        seleccion.id = this.pedidosIniciales.reduce((max, ped) => ped.seleccions.find(s => (s?.id ?? 0) > max)?.id ?? max, 0) + 1;
        ped.seleccions.push(seleccion);
        return Promise.resolve(seleccion);
      }
    }
    return Promise.resolve(null);
  }

public ActualizarSeleccion(seleccion:Seleccion|null): Promise<Seleccion|null> {
  for(let ped of this.pedidosIniciales){
    const sels =  ped.seleccions;
    for(let indSel in sels) {
      if(seleccion!=null && sels[indSel]!=null && sels[indSel].id==seleccion.id) {
        sels[indSel] = seleccion;
        return Promise.resolve(seleccion);
      }
    }
   
  }
  return Promise.resolve(null);
}

public obtenerSeleccionPorId(seleccionId:number|null): Promise<Seleccion|null> {
  let seleccion = this.pedidosIniciales.reduce((sels,ped)=>sels.concat(ped.seleccions), new Array<Seleccion>()).find(s => s.id == seleccionId);
  return Promise.resolve(seleccion==null?null:seleccion);
}

public obtenerPedidoPorId(pedidoId:number): Promise<Pedido|null> {
  let pedido = this.pedidosIniciales.find(p => p.id == pedidoId);
  return Promise.resolve(pedido==null?null:pedido);
}

public obtenerSeleccionesPorPedido(pedidoId:number|null): Promise<Seleccion[]|null> {
  let pedido = this.pedidosIniciales.find(s => s.id == pedidoId);
  return Promise.resolve(pedido==null?new Array<Seleccion>():pedido.seleccions);
}

public obtenerPedidosPorMesa(mesaId:number): Promise<Pedido[]> {
  let pedidos = this.pedidosIniciales.filter(p => p?.mesa?.id == mesaId);
  return Promise.resolve(pedidos);
}

}
function seleccion(seleccion: any) {
  throw new Error('Function not implemented.');
}

