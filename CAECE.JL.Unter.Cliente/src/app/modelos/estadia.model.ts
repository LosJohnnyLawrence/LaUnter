import { Mesa } from "./mesa.model";
import { Mozo } from "./mozo.model";
import { Cliente, Pedido } from "./pedido.model";

export class Estadia {
    public id:number |null =null;
    public mesa:Mesa |null =null;
    public cliente:Cliente |null =null;
    public fechaInicio:Date |null =null;
    public fechaFin:Date |null =null;
    public mozo:Mozo |null =null;
    public pedidos: Pedido[]  = new Array<Pedido>();
}
