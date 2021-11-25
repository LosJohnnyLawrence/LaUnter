import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MesaComponent } from './mesa/mesa.component';
import { PedidoComponent } from './pedido/pedido.component';

const routes: Routes = [
  {path:'pedido/:pedidoId', component:PedidoComponent},
  {path:'pedido', component:PedidoComponent},
  {path:'mesa/:mesaId', component:MesaComponent}


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MozoRoutingModule { }
