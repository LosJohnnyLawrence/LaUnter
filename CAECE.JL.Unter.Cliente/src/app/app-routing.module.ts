import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CajaComponent } from './componentes/caja/caja.component';
import { CocinaComponent } from './componentes/cocina/cocina.component';
import { ConfigComponent } from './componentes/config/config.component';
import { HomeComponent } from './componentes/home/home.component';
import { MozoComponent } from './componentes/mozo/mozo.component';

const routes: Routes = [
  {path:'mozo',component: MozoComponent},
  {path:'caja',component: CajaComponent},
  {path:'cocina',component: CocinaComponent},
  {path:'config',component: ConfigComponent},
  {path:'home',component: HomeComponent},
  {path:'ayuda',component: HomeComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
