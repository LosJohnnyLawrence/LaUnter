import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatMenuModule } from '@angular/material/menu';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { MatDividerModule } from '@angular/material/divider';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatTableModule } from '@angular/material/table';
import {MatExpansionModule} from '@angular/material/expansion';

import { ComunRoutingModule } from './comun-routing.module';
import { CarroComponent } from './carro/carro.component';
import { ListaSeleccionComponent } from './lista-seleccion/lista-seleccion.component';
import { DetalleSeleccionComponent } from './detalle-seleccion/detalle-seleccion.component';
import { DetalleItemComponent } from './detalle-item/detalle-item.component';
import { DetalleMesaComponent } from './detalle-mesa/detalle-mesa.component';
import { DetallePedidoComponent } from './detalle-pedido/detalle-pedido.component';
import { ListadoItemsComponent } from './listado-items/listado-items.component';
import { ListadoMesasComponent } from './listado-mesas/listado-mesas.component';
import { ListadoPedidosComponent } from './listado-pedidos/listado-pedidos.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import {MatGridListModule} from '@angular/material/grid-list';


@NgModule({
  declarations: [    
    CarroComponent,
    ListaSeleccionComponent,
    DetalleSeleccionComponent,
    DetalleItemComponent,
    DetalleMesaComponent,
    DetallePedidoComponent,
    ListadoItemsComponent,
    ListadoMesasComponent,
    ListadoPedidosComponent
  ],
  imports: [   
    MatCardModule,
    MatSidenavModule,
    MatToolbarModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    MatMenuModule,
    MatSelectModule,
    MatDividerModule,  
    MatExpansionModule,  
    FlexLayoutModule ,
    ComunRoutingModule,
    MatTableModule,
    MatDialogModule,
    MatInputModule,
    FormsModule,
    MatGridListModule
  ],
  exports:[ MatCardModule,
    MatSidenavModule,
    MatToolbarModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    MatMenuModule,
    MatDividerModule,  
    MatExpansionModule, 
    MatTableModule, 
    FlexLayoutModule ,
    ComunRoutingModule,
    CarroComponent,
    ListaSeleccionComponent,
    DetalleSeleccionComponent,
    DetalleItemComponent,
    DetalleMesaComponent,
    DetallePedidoComponent,
    ListadoItemsComponent,
    ListadoMesasComponent,
    ListadoPedidosComponent,
    MatDialogModule,
    MatInputModule,
    FormsModule,
    MatSelectModule,
    MatGridListModule
  ]
})
export class ComunModule { }
