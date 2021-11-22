import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {

 rutas = [
    { nombre: 'Mozo', url: '/mozo' },
    { nombre: 'Caja', url: '/caja' },
    { nombre: 'Cocina', url: '/cocina' },
    { nombre: 'Config', url: '/config' },
    { nombre: 'Ayuda', url: '/ayuda' }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
