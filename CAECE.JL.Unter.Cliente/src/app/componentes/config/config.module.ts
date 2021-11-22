import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ConfigRoutingModule } from './config-routing.module';
import { ConfigComponent } from './config.component';
import { ComunModule } from '../comun/comun.module';
import { MenuComponent } from './menu/menu.component';
import { MozoComponent } from './mozo/mozo.component';
import { MesaComponent } from './mesa/mesa.component';


@NgModule({
  declarations: [ConfigComponent, MenuComponent, MozoComponent, MesaComponent],
  imports: [
    ComunModule,
    CommonModule,
    ConfigRoutingModule
  ],

})
export class ConfigModule { }
