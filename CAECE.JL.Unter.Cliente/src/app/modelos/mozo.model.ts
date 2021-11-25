import { Sector } from "./mesa.model";

export class Turno {

    constructor(turno:Turno|null=null){
        if(turno!=null){
        this.id = turno.id;
        this.dia = turno.dia;
        this.entrada = turno.entrada;
        this.salida = turno.salida;
        this.sector = turno.sector;
        }
    }
    public sector: Sector | null = null;
    public dia: number | null = null;
    public id: number | null = null;
    public entrada: string | null = null;
    public salida: string | null = null;
}
export class Mozo {
    constructor(mozo:Mozo|null=null){
        if(mozo!=null){
        this.id = mozo.id;
        this.nombre = mozo.nombre;
        this.DNI = mozo.DNI;
        this.turnos = mozo.turnos.map(t=>new Turno(t));
        }
    }
    public id: number | null =null;
    public nombre: string | null = null;
    public DNI: string | null = null;
    public turnos: Turno[] = new Array<Turno>();
}
