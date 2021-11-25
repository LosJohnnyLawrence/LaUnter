import { Item } from "./item.model";
import { Mesa } from "./mesa.model";
import { Mozo } from "./mozo.model";

export class EstadoPreparacion {
    public id:number|null=null;
    public nombre: string|null|undefined=null;
    public descripcion: string|null|undefined=null;
}

export class Seleccion {
    public id: number | null = null;
    public cantidad: number | null = null;
    public item: Item | null = null;
    public agregar: Item[] = Array<Item>();
    public sacar: Item[] = Array<Item>();
    public estado: EstadoPreparacion|null =  null;
}

export class Cliente {
    public id:number|null=null;
    public nombre: string|null|undefined=null;
    public DNI: string | null = null;
    public mesa: Mesa | null = null;
}

export class Pedido {
    public notas: string | null = null;
    public nombre: string | null = null;
    public id: number | null = null;
    public mesa: Mesa | null = null;
    public mozo: Mozo | null = null;
    public cliente: Cliente | null = null;
    public estado: EstadoPreparacion | null = null;
    public seleccions: Seleccion[] = new Array<Seleccion>();
}


       