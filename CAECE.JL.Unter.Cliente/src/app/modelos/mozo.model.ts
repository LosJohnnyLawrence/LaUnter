export class Turno {
    public sector: number | null = null;
    public dia: number | null = null;
    public entrada: string | null = null;
    public salida: string | null = null;
}
export class Mozo {
    public id: number | null =null;
    public nombre: string | null = null;
    public DNI: string | null = null;
    public turnos: Turno[] | null = new Array<Turno>();
}
