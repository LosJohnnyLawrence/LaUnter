import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ConfigRoutingModule } from './config-routing.module';
import { ConfigComponent } from './config.component';
import { ComunModule } from '../comun/comun.module';
import { MenuComponent } from './menu/menu.component';
import { MozoComponent } from './mozo/mozo.component';
import { MesaComponent } from './mesa/mesa.component';
import { ItemFormComponent } from './menu/item-form/item-form.component';
import { ItemListComponent } from './menu/item-list/item-list.component';
import { PlatoFormComponent } from './menu/item-form/plato-form/plato-form.component';
import { BebidaFormComponent } from './menu/item-form/bebida-form/bebida-form.component';
import { IngredienteFormComponent } from './menu/item-form/ingrediente-form/ingrediente-form.component';


@NgModule({
  declarations: [ConfigComponent, MenuComponent, MozoComponent,
    MesaComponent, ItemFormComponent, ItemListComponent,
    PlatoFormComponent, BebidaFormComponent, IngredienteFormComponent],
  imports: [
    ComunModule,
    CommonModule,
    ConfigRoutingModule
  ],

})
export class ConfigModule { }
