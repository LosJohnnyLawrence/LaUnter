import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Bebida, Categoria, Item, RestriccionAlimentaria } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-bebida-form',
  templateUrl: './bebida-form.component.html',
  styleUrls: ['./bebida-form.component.scss']
})
export class BebidaFormComponent implements OnInit {
  @Input() posiblesComponentes: Item[]|null = null; 
  @Input() posiblesRestricciones: RestriccionAlimentaria[]|null = null; 
  @Input() posiblesCategorias: Categoria[]|null = null; 
  @Input() bebidaData: Bebida = new Bebida();
  @Input() editing = false;
  @Output() guardar = new EventEmitter<Bebida>();
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

  guardarHandler (item:Item){
    let nuevo = new Bebida(item); 
    nuevo.categoria = this.bebidaData.categoria;
    nuevo.restriccionesAlimentarias = this.bebidaData.restriccionesAlimentarias;
    this.guardar.emit(nuevo);    
  }
  cancelarHandler (){
    this.cancelar.emit();
  }

}
