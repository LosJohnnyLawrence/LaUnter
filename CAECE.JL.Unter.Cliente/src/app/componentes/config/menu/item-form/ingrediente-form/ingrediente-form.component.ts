import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Ingrediente, Item } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-ingrediente-form',
  templateUrl: './ingrediente-form.component.html',
  styleUrls: ['./ingrediente-form.component.scss']
})
export class IngredienteFormComponent implements OnInit {
  @Input() posiblesComponentes: Ingrediente[]|null = null; 
  @Input() ingredienteData: Ingrediente = new Ingrediente();
  @Input() editing = false;
  @Output() guardar = new EventEmitter<Ingrediente>();
  @Output() cancelar = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }

  // compareComponentes(item:Item, comp: Item): boolean{
  //   return item != null && comp != null && (item?.id == comp?.id);
  // }

  guardarHandler (item:Item){
    let nuevo = new Ingrediente(item); 
    nuevo.costo = this.ingredienteData.costo;
    nuevo.cantidadStock = this.ingredienteData.cantidadStock;
    this.guardar.emit(nuevo);    
  }
  cancelarHandler (){
    this.cancelar.emit();
  }

}
