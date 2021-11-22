import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MozoRoutingModule } from './mozo-routing.module';
import { ComunModule } from '../comun/comun.module';
import { MesaComponent } from './mesa/mesa.component';
import { MozoComponent } from './mozo.component';
import { PedidoComponent } from './pedido/pedido.component';


@NgModule({
  declarations: [
    MesaComponent,
  PedidoComponent,
  MozoComponent
],
  imports: [
    ComunModule,
    CommonModule,
    MozoRoutingModule
  ]
})
export class MozoModule { }
