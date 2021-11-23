import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedido.component.html',
  styleUrls: ['./pedido.component.scss']
})
export class PedidoComponent implements OnInit {

  pedidoId:string|null=null;
  constructor( private route: ActivatedRoute){}
  ngOnInit(){
    this.route.params.subscribe(routeParams => {
      this.pedidoId = routeParams['pedidoId'];
  });
  }

}
