import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AyudaComponent } from './componentes/ayuda/ayuda.component';
import { CajaComponent } from './componentes/caja/caja.component';
import { CocinaComponent } from './componentes/cocina/cocina.component';
import { ConfigComponent } from './componentes/config/config.component';
import { HomeComponent } from './componentes/home/home.component';
import { MozoComponent } from './componentes/mozo/mozo.component';

const routes: Routes = [
  {path:'mozo',component: MozoComponent,
  loadChildren: ()=>import('./componentes/mozo/mozo.module').then(m=>m.MozoModule) },
  {path:'caja',component: CajaComponent},
  {path:'cocina',component: CocinaComponent},
  {path:'config',component: ConfigComponent,
    loadChildren: ()=>import('./componentes/config/config.module').then(m=>m.ConfigModule)  },
  {path:'home',component: HomeComponent},
  {path:'ayuda',component: AyudaComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
