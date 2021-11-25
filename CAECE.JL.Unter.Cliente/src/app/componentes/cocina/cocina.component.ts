import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Pedido } from 'src/app/modelos/pedido.model';
import { PedidoService } from 'src/app/servicios/pedido.service';

@Component({
  selector: 'app-cocina',
  templateUrl: './cocina.component.html',
  styleUrls: ['./cocina.component.scss']
})
export class CocinaComponent implements OnInit {
  listaPedido = new MatTableDataSource<Pedido>();
  displayedColumns = ['id','item','editar','estado','summary'];
  constructor(private pedidoService:PedidoService) { }

  getSummary(pedido:Pedido){
    return pedido.seleccions.reduce((str, sel)=> str = sel.item?.nombre!=null && sel.item?.precio!=null? str+'|'+sel.item?.nombre+':'+sel.item?.precio:str+'|'+sel.id,'')
  }
 
  ngOnInit(): void {
    this.pedidoService.ObtenerPedidos().then(p=>this.listaPedido.data=p);
  }

}
