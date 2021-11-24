export class Mesa {
    public id:number|null=null;
    public nombre:string|null=null;
    public descripcion:string|null=null;
    public sectorId:number|null=null;
    public cantComensales:number|null=null;
}

export class Sector {
    public id:number|null=null;
    public nombre: string|null|undefined=null;
    public descripcion: string|null|undefined=null;
}