export class Categoria {
    public id: number | null = null;
    public nombre: string | null = null;
    public descripcion: string | null = null;
}

export class RestriccionAlimentaria {
    public id: number | null = null;
    public nombre: string | null = null;
    public descripcion: string | null = null;
}

export class Item {
    public id: number | null = null;
    public nombre: string | null = null;
    public descripcion: string | null = null;
    public precio: number | null = null;
    public componentes: Item[] = new Array<Item>();
    constructor(item:Item|null|undefined = null){
        if(item != null) {
            this.id = item.id;
            this.nombre = item.nombre;
            this.descripcion = item.descripcion;
            this.precio = item.precio;
            this.componentes = item.componentes;
        }
    }
}

export class Plato extends Item {
    constructor(item:Item|null=null){
        super(item);
    }
    public static clonar(viejo: Plato): Plato {
        const nuevo = new Plato(viejo);
        nuevo.categoria = viejo.categoria;
        nuevo.restriccionesAlimentarias = [...viejo.restriccionesAlimentarias];
        nuevo.posiblesExtras = [...viejo.posiblesExtras];
        return nuevo;
    }
    public posiblesExtras: Item[] = new Array<Item>();
    public categoria: Categoria = new Categoria();
    public restriccionesAlimentarias: RestriccionAlimentaria[] = new Array<RestriccionAlimentaria>();
}

export class Bebida extends Item {
    constructor(item:Item|null=null){
        super(item);
    }
    public static clonar(viejo:Bebida):Bebida {
        const nuevo = new Bebida(viejo);
        nuevo.categoria = viejo.categoria;
        nuevo.restriccionesAlimentarias = [...viejo.restriccionesAlimentarias];
        return nuevo;
    }
    public categoria: Categoria = new Categoria();
    public restriccionesAlimentarias: RestriccionAlimentaria[] = new Array<RestriccionAlimentaria>();
}

export class Ingrediente extends Item {
    constructor(item:Item|null=null){
        super(item);
    }
    public static clonar(viejo:Ingrediente):Ingrediente {
        const nuevo = new Ingrediente(viejo);
        nuevo.costo = viejo.costo;
        nuevo.cantidadStock = viejo.cantidadStock;
        return nuevo;
    }

    public costo: number | null = null;
    public cantidadStock: number = 0;
}


