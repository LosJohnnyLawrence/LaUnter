import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MozoComponent } from './mozo/mozo.component';
import { MenuComponent } from './menu/menu.component';
import { MesaComponent } from './mesa/mesa.component';

const routes: Routes = [
  {path:'menu',component: MenuComponent},
  {path:'mozo',component: MozoComponent},
  {path:'mesa',component: MesaComponent}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ConfigRoutingModule { }
