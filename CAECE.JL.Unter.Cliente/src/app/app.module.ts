import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CocinaComponent } from './componentes/cocina/cocina.component';
import { ConfigModule } from './componentes/config/config.module';
import { CajaComponent } from './componentes/caja/caja.component';
import { MesaComponent } from './componentes/mozo/mesa/mesa.component';
import { HomeComponent } from './componentes/home/home.component';
import { AyudaComponent } from './componentes/ayuda/ayuda.component';
import { NavBarComponent } from './componentes/nav-bar/nav-bar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PedidoComponent } from './componentes/mozo/pedido/pedido.component';
import { MozoModule } from './componentes/mozo/mozo.module';
import { ComunModule } from './componentes/comun/comun.module';
import { DialogoAccionComponent } from './componentes/caja/dialogo-accion/dialogo-accion.component';
import { MozoService } from './servicios/mozo.service';
import { PedidoService } from './servicios/pedido.service';
import { MesaService } from './servicios/mesa.service';
import { ItemService } from './servicios/item.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';
  

@NgModule({
  declarations: [
    AppComponent,
    CocinaComponent,
    CajaComponent,
    HomeComponent,
    AyudaComponent,
    NavBarComponent,
    DialogoAccionComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ComunModule,
    ConfigModule,
    MozoModule,
    HttpClientModule
  ],
  providers: [
    MozoService,
    PedidoService,
    MesaService,
    ItemService,
    HttpClient    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
