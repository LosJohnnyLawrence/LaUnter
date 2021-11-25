import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { Bebida, Ingrediente, Plato } from 'src/app/modelos/item.model';
import { Pedido, Seleccion } from 'src/app/modelos/pedido.model';
import { ItemService } from 'src/app/servicios/item.service';
import { MesaService } from 'src/app/servicios/mesa.service';
import { PedidoService } from 'src/app/servicios/pedido.service';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedido.component.html',
  styleUrls: ['./pedido.component.scss']
})
export class PedidoComponent implements OnInit {

  pedidoId: string | null = null;
  pedido: Pedido | null = null;
  editar: boolean = false;
  seleccionActual: Seleccion = new Seleccion();

  listaSelecciones = new MatTableDataSource<Seleccion>();
  listaBebidas: Bebida[] | null = new Array<Bebida>();
  listaPlatos: Plato[] | null = new Array<Plato>();
  listaIngredientes: Ingrediente[] | null = new Array<Ingrediente>();



  displayedColumns = ['id', 'item', 'editar', 'devolver', 'avanzar', 'cancelar', 'estado'];

  constructor(private route: ActivatedRoute, private itemService: ItemService,
    private mesaService: MesaService, private pedidoService: PedidoService) { }
  ngOnInit() {
    this.actualizarItems();
    this.route.params.subscribe(routeParams => {
      this.pedidoId = routeParams['pedidoId'];
      this.pedidoService.obtenerPedidoPorId(Number.parseInt(this.pedidoId ?? '-1')).then(s => this.pedido = s);
      this.pedidoService.obtenerSeleccionesPorPedido(Number.parseInt(this.pedidoId ?? '-1')).then(s => this.listaSelecciones.data = s??new Array<Seleccion>());
    });
  }

  actualizarItems() {
    this.itemService.obtenerBebidas().then(b => this.listaBebidas = b);
    this.itemService.obtenerPlatos().then(p => this.listaPlatos = p);
    this.itemService.obtenerIngredientes().then(i => this.listaIngredientes = i);
    if (this.pedidoId != null) {
      this.pedidoService.obtenerPedidoPorId(Number.parseInt(this.pedidoId ?? '-1')).then(s => this.pedido = s);
      this.pedidoService.obtenerSeleccionesPorPedido(Number.parseInt(this.pedidoId ?? '-1')).then(s => this.listaSelecciones.data = s??new Array<Seleccion>());
    }
  }
  accionClick(seleccion: Seleccion | null = null) {
    this.seleccionActual = seleccion ?? new Seleccion();
    this.editar = true;
  }

  guardarSeleccion(seleccion: Seleccion | null = null) {
    if (seleccion == null) { return; }
    if (seleccion.id == null) {
      this.pedidoService.CrearSeleccion(seleccion, this.pedido);
      return;
    }
    this.pedidoService.ActualizarSeleccion(seleccion);
    this.seleccionActual = new Seleccion();
    this.editar = false;
    this.actualizarItems();
  }

  cancelar() {
    this.seleccionActual = new Seleccion();
    this.editar = false;
    this.actualizarItems();
  }

  avanzarPedido(pedido: Pedido | null = null) {
    this.pedidoService.AvanzarEstadoPedido(pedido);
    this.actualizarItems();
  }
  devolverPedido(pedido: Pedido | null = null) {
    this.pedidoService.RetrocedeEstadoPedido(pedido);
    this.actualizarItems();
  }
  cancelarPedido(pedido: Pedido | null = null) {
    this.pedidoService.CancelearEstadoPedido(pedido);
    this.actualizarItems();
  }

  avanzarSeleccion(seleccion: Seleccion | null = null) {
    this.pedidoService.AvanzarEstadoSeleccion(seleccion);
    this.actualizarItems();
  }
  devolverSeleccion(seleccion: Seleccion | null = null) {
    this.pedidoService.RetrocedeEstadoSeleccion(seleccion);
    this.actualizarItems();
  }
  cancelarSeleccion(seleccion: Seleccion | null = null) {
    this.pedidoService.CancelearEstadoSeleccion(seleccion);
    this.actualizarItems();
  }
}
