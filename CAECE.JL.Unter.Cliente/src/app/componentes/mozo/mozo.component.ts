import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Mesa } from 'src/app/modelos/mesa.model';
import { EstadoPreparacion, Pedido } from 'src/app/modelos/pedido.model';
import { MesaService } from 'src/app/servicios/mesa.service';
import { PedidoService } from 'src/app/servicios/pedido.service';

@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  listaMesas:Mesa[]=[];
  listPedidos = new MatTableDataSource<Pedido>();
  listEstados:EstadoPreparacion[]=[];

  displayedColumns = ['id','item','editar','estado'];

  constructor(private pedidosService:PedidoService, private mesaService:MesaService) { }

  ngOnInit(): void {
    this.actualizarPedidos();
  }

  obtenerSource(){return this.listPedidos ?? new Array<Pedido>();}

  actualizarPedidos(){
    this.pedidosService.ObtenerPedidos().then(p=> this.listPedidos.data=p);
    this.pedidosService.ObetenerEstados().then(e=> this.listEstados=e);
    this.mesaService.obtenerTodos().then(m=>this.listaMesas=m);

  }
}
