import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MozoRoutingModule } from './mozo-routing.module';
import { ComunModule } from '../comun/comun.module';
import { MesaComponent } from './mesa/mesa.component';
import { MozoComponent } from './mozo.component';
import { PedidoComponent } from './pedido/pedido.component';
import { ListaBebidaComponent } from './pedido/lista-bebida/lista-bebida.component';
import { ListaPlatosComponent } from './pedido/lista-platos/lista-platos.component';
import { EdicionSelecComponent } from './pedido/edicion-selec/edicion-selec.component';


@NgModule({
  declarations: [
    MesaComponent,
  PedidoComponent,
  MozoComponent,
  ListaBebidaComponent,
  ListaPlatosComponent,
  EdicionSelecComponent
],
  imports: [
    ComunModule,
    CommonModule,
    MozoRoutingModule
  ]
})
export class MozoModule { }
