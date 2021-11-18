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
import { CarroComponent } from './componentes/comun/carro/carro.component';
import { ListaSeleccionComponent } from './componentes/comun/lista-seleccion/lista-seleccion.component';
import { DetalleSeleccionComponent } from './componentes/comun/detalle-seleccion/detalle-seleccion.component';
import { DetalleItemComponent } from './componentes/comun/detalle-item/detalle-item.component';
import { DetalleMesaComponent } from './componentes/comun/detalle-mesa/detalle-mesa.component';
import { DetallePedidoComponent } from './componentes/comun/detalle-pedido/detalle-pedido.component';

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
    NavBarComponent,
    CarroComponent,
    ListaSeleccionComponent,
    DetalleSeleccionComponent,
    DetalleItemComponent,
    DetalleMesaComponent,
    DetallePedidoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
