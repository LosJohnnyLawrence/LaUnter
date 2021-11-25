import { Sector } from "./mesa.model";

export class Turno {
    public sector: Sector | null = null;
    public dia: number | null = null;
    public entrada: string | null = null;
    public salida: string | null = null;
}
export class Mozo {
    constructor(mozo:Mozo|null=null){
        if(mozo!=null){
        this.id = mozo.id;
        this.nombre = mozo.nombre;
        this.DNI = mozo.DNI;
        this.turnos = [...mozo.turnos];
        }
    }
    public id: number | null =null;
    public nombre: string | null = null;
    public DNI: string | null = null;
    public turnos: Turno[] = new Array<Turno>();
}
