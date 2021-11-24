import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Item } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
  styleUrls: ['./item-form.component.scss']
})
export class ItemFormComponent implements OnInit {

  @Input() posiblesComponentes: Item[]|null = null; 
  @Input() itemData: Item = new Item();
  @Input() editing=false;
  @Output() guardar = new EventEmitter<Item|null>();
  @Output() cancelar = new EventEmitter();

 
  constructor() { }

  ngOnInit(): void {
  }

  compareComponentes(item:Item, comp: Item): boolean{
    return item != null && comp != null && (item?.id == comp?.id);
  }

  guardarHandler (){
      this.guardar.emit(this.itemData);    
  }
  cancelarHandler (){
    this.cancelar.emit();
  }

}
