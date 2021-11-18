import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MozoComponent } from './componentes/mozo/mozo.component';
import { CocinaComponent } from './componentes/cocina/cocina.component';
import { ConfigComponent } from './componentes/config/config.component';
import { CajaComponent } from './componentes/caja/caja.component';
import { ListadoItemsComponent } from './componentes/comun/listado-items/listado-items.component';
import { ListadoMesasComponent } from './componentes/comun/listado-mesas/listado-mesas.component';
import { ListadoPedidosComponent } from './componentes/comun/listado-pedidos/listado-pedidos.component';
import { MesaComponent } from './componentes/mozo/mesa/mesa.component';
import { HomeComponent } from './componentes/home/home.component';
import { AyudaComponent } from './componentes/ayuda/ayuda.component';
import { NavBarComponent } from './componentes/nav-bar/nav-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    MozoComponent,
    CocinaComponent,
    ConfigComponent,
    CajaComponent,
    ListadoItemsComponent,
    ListadoMesasComponent,
    ListadoPedidosComponent,
    MesaComponent,
    HomeComponent,
    AyudaComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
