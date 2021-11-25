import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Mesa } from 'src/app/modelos/mesa.model';
import { Pedido } from 'src/app/modelos/pedido.model';
import { MesaService } from 'src/app/servicios/mesa.service';
import { PedidoService } from 'src/app/servicios/pedido.service';

@Component({
  selector: 'app-mesa',
  templateUrl: './mesa.component.html',
  styleUrls: ['./mesa.component.scss']
})
export class MesaComponent implements OnInit {

  mesaId:string|null=null;
  listaPedidos:Pedido[]=new Array<Pedido>();
  mesaData:Mesa|null=null;
  displayedColumns = ['id','item','editar','estado','summary'];

  constructor( private route: ActivatedRoute,
     private mesaService:MesaService, private pedidoService:PedidoService) { }

 getSummary(pedido:Pedido){
   return pedido.seleccions.reduce((str, sel)=> str = sel.item?.nombre!=null && sel.item?.precio!=null? str+'|'+sel.item?.nombre+':'+sel.item?.precio:str+'|'+sel.id,'')
 }

  ngOnInit(): void {
    this.route.params.subscribe(routeParams => {
      this.mesaId = routeParams['mesaId'];
      this.mesaService.obtenerMesa(Number.parseInt(this.mesaId??'-1')).then(m=>this.mesaData=m);
      this.pedidoService.obtenerPedidosPorMesa(Number.parseInt(this.mesaId??'-1')).then(p=>this.listaPedidos=p);

  });
  }
  obtenerSource(){return this.listaPedidos ?? new Array<Pedido>();}


}
