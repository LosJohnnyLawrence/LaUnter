import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Item } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.scss']
})
export class ItemListComponent implements OnInit {

  @Input() items:Item[] = new Array<Item>();
  @Output() accionDeLista = new EventEmitter<Item>();

  constructor() { }

  ngOnInit(): void {
  }

  handlerAccion(item:Item){
    this.accionDeLista.emit(item);
  }

}
