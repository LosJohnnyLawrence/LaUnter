import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Bebida, Ingrediente, Item, Plato } from 'src/app/modelos/item.model';
import { Seleccion } from 'src/app/modelos/pedido.model';


@Component({
  selector: 'app-edicion-selec',
  templateUrl: './edicion-selec.component.html',
  styleUrls: ['./edicion-selec.component.scss']
})
export class EdicionSelecComponent implements OnInit {

  @Input() seleccion:Seleccion = new Seleccion();
  @Input() bebidas:Bebida[]|null = new Array<Bebida>();
  @Input() platos:Plato[]|null = new Array<Plato>();
  @Input() ingredientes:Ingrediente[]|null = new Array<Ingrediente>();
  @Output() guardar = new EventEmitter<Seleccion>();
  @Output() cancelar = new EventEmitter();




  constructor() { }

  ngOnInit(): void {
    console.log(this.seleccion)
  }

  itemSeleccionado(item:Item) {
    if(this.seleccion==null){
      this.seleccion= new Seleccion();
    }
    this.seleccion.item=item;
  }

    ingredientesAgregado(items:Item[]) {
    if(this.seleccion==null){
      this.seleccion= new Seleccion();
    }
    this.seleccion.agregar=items;
  }

  ingredientesSacados(items:Item[]) {
    if(this.seleccion==null){
      this.seleccion= new Seleccion();
    }
    this.seleccion.sacar=items;
  }
  compareComponentes(item:Item, comp: Item): boolean{
    return item != null && comp != null && (item?.id == comp?.id);
  }
  handlerGuardar(seleccion: Seleccion) {
    this.guardar.emit(seleccion);
   }

  handlerCancelar() {
    this.cancelar.emit();
  }

}
