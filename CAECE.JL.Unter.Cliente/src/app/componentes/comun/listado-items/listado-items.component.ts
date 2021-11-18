import { ArrayType } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { Item } from 'src/app/modelos/item.model';

@Component({
  selector: 'app-listado-items',
  templateUrl: './listado-items.component.html',
  styleUrls: ['./listado-items.component.scss']
})
export class ListadoItemsComponent implements OnInit {
  @Input() items:Item[]=new Array<Item>();
  constructor() { }
 
  ngOnInit(): void {
  }

}
