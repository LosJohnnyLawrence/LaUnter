import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Plato, Item, RestriccionAlimentaria, Categoria } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-plato-form',
  templateUrl: './plato-form.component.html',
  styleUrls: ['./plato-form.component.scss']
})
export class PlatoFormComponent implements OnInit {
  @Input() posiblesComponentes: Item[]|null = null; 
  @Input() posiblesRestricciones: RestriccionAlimentaria[]|null = null; 
  @Input() posiblesCategorias: Categoria[]|null = null; 
  @Input() platoData: Plato = new Plato();
  @Input() editing = false;
  @Output() guardar = new EventEmitter<Plato>();
  @Output() cancelar = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }

  compareCategorias(cat1:Categoria,cat2:Categoria){
    return cat1 != null && cat2 != null && (cat1?.id == cat2?.id);
  }
  compareRestricciones(res1:RestriccionAlimentaria,res2:RestriccionAlimentaria){
    return res1 != null && res2 != null && (res1?.id == res2?.id);
  }
  compareComponentes(item:Item, comp: Item): boolean{
    return item != null && comp != null && (item?.id == comp?.id);
  }

  guardarHandler (item:Item){
    let nuevo = new Plato(item); 
    nuevo.categoria = this.platoData.categoria;
    nuevo.restriccionesAlimentarias = this.platoData.restriccionesAlimentarias;
    nuevo.posiblesExtras = this.platoData.posiblesExtras;
    this.guardar.emit(nuevo);    
  }
  cancelarHandler (){
    this.cancelar.emit();
  }

}
