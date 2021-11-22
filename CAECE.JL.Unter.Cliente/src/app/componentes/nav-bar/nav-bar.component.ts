import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {

 rutas = [
    { nombre: 'mozo', url: '/mozo' },
    { nombre: 'caja', url: '/caja' },
    { nombre: 'cocina', url: '/cocina' },
    { nombre: 'config', url: '/config' },
    { nombre: 'ayuda', url: '/ayuda' }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
