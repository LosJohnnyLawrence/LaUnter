export class Mesa {
    constructor(mesa:Mesa|null=null){
        if(mesa!=null) {
            this.id = mesa.id;
            this.nombre = mesa.nombre;
            this.descripcion = mesa.descripcion;
            this.sector = mesa.sector;
            this.cantComensales = mesa.cantComensales;
        }        
    }
    public id:number|null=null;
    public nombre:string|null=null;
    public descripcion:string|null=null;
    public sector:Sector|null=null;
    public cantComensales:number|null=null;
}

export class Sector {
    public id:number|null=null;
    public nombre: string|null|undefined=null;
    public descripcion: string|null|undefined=null;
}