import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Pedido, Seleccion } from 'src/app/modelos/pedido.model';
import { MesaService } from 'src/app/servicios/mesa.service';
import { PedidoService } from 'src/app/servicios/pedido.service';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedido.component.html',
  styleUrls: ['./pedido.component.scss']
})
export class PedidoComponent implements OnInit {

  pedidoId:string|null=null;
  pedido:Pedido|null=null;

  listaSelecciones:Seleccion[]|null=new Array<Seleccion>();
  displayedColumns = ['id','item','editar','devolver','avanzar','cancelar','estado'];

  constructor( private route: ActivatedRoute,
    private mesaService:MesaService, private pedidoService:PedidoService){}
  ngOnInit(){
    this.route.params.subscribe(routeParams => {
      this.pedidoId = routeParams['pedidoId'];
      this.pedidoService.obtenerPedidoPorId(Number.parseInt(this.pedidoId??'-1')).then(s=>this.pedido=s);
      this.pedidoService.obtenerSeleccionesPorPedido(Number.parseInt(this.pedidoId??'-1')).then(s=>this.listaSelecciones=s);
  });
  }
 obtenerSource(){return this.listaSelecciones ?? new Array<Seleccion>();}

  accionClick(seleccion:Seleccion|null=null){
    console.log(seleccion)
  }

  avanzarPedido(pedido:Pedido|null=null){
    this.pedidoService.AvanzarEstadoPedido(pedido);
  }
  devolverPedido(pedido:Pedido|null=null){
    this.pedidoService.RetrocedeEstadoPedido(pedido);
  }
  cancelarPedido(pedido:Pedido|null=null){
    this.pedidoService.CancelearEstadoPedido(pedido);
  }
  
  avanzarSeleccion(seleccion:Seleccion|null=null){
    this.pedidoService.AvanzarEstadoSeleccion(seleccion);
  }
  devolverSeleccion(seleccion:Seleccion|null=null){
    this.pedidoService.RetrocedeEstadoSeleccion(seleccion);
  }
  cancelarSeleccion(seleccion:Seleccion|null=null){
    this.pedidoService.CancelearEstadoSeleccion(seleccion);
  }
}
