import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  pedidosOrdenes=[
    { id:1,descripcion:"sarasa 1"},
    { id:3,descripcion:"sarasa 2"}
]
  constructor() { }

  ngOnInit(): void {
  }

}
