import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PedidoComponent } from './pedido/pedido.component';

const routes: Routes = [
  {path:'pedido/:pedidoId', component:PedidoComponent},
  {path:'pedido', component:PedidoComponent},
  {path:'mesa/:pedidoId', component:PedidoComponent}


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MozoRoutingModule { }
