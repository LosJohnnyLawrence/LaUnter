import { Component, OnInit } from '@angular/core';
import { Bebida, Categoria, Ingrediente, Item, Plato, RestriccionAlimentaria } from 'src/app/modelos/item.model';
import { ItemService } from 'src/app/servicios/item.service';


@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  itemEditId: number | null = null;
  editingBebida = false;
  editingIngrediente = false;
  editingPlato = false;

  dataBebida: Bebida = new Bebida();
  dataIngrediente: Ingrediente  = new Ingrediente();
  dataPlato: Plato  = new Plato();

  listaBebida: Bebida[] = new Array<Bebida>();
  listIngrediente: Ingrediente[] = new Array<Ingrediente>();
  listaPlato: Plato[] = new Array<Plato>();
  listaCategorias: Categoria[] = new Array<Categoria>();
  listaRestriccions: RestriccionAlimentaria[] = new Array<RestriccionAlimentaria>();





  constructor(private itemService: ItemService) { }

  ngOnInit(): void {
    this.actualizarIngredientes();
  }

  actualizarIngredientes() {
    this.itemService.obtenerBebidas().then(b => { this.listaBebida = b; });
    this.itemService.obtenerPlatos().then(p => { this.listaPlato = p; });
    this.itemService.obtenerIngredientes().then(i => { this.listIngrediente = i; });
    this.itemService.obtenerRestricciones().then(i => { this.listaRestriccions = i; });
    this.itemService.obtenerCategorias().then(i => { this.listaCategorias = i; });

  }

  inicioNuevoPlato() {
    this.editingPlato = true;
    this.dataPlato = new Plato();
  }
  inicioNuevoBebida() {
    this.editingBebida = true;
    this.dataBebida = new Bebida();
  }
  inicioNuevoIngrediente() {
    this.editingIngrediente = true;
    this.dataIngrediente = new Ingrediente();
  }

  inicioEditPlato(item: Item) {
    const id = item.id;
    this.editingPlato = true;
    this.itemService.obtenerPlato(id).then(b => { this.dataPlato = b??new Plato(); });
  }

  inicioEditBebida(item: Item) {
    const id = item.id;
    this.editingBebida = true;
    this.itemService.obtenerBebida(id).then(p => {this.dataBebida = p??new Bebida(); });
  }

  inicioEditIngrediente(item: Item) {
    const id = item.id;
    this.editingIngrediente = true;
    this.itemService.obtenerIngrediente(id).then(p => {this.dataIngrediente = p??new Ingrediente();});
  }

  cancelEditPlato() {
    this.editingPlato = false;
  }

  cancelEditBebida() {
    this.editingBebida = false;
  }

  cancelEditIngrediente() {
    this.editingIngrediente = false;
  }


  guardarPlato(plato: Plato|null) {
    this.editingPlato = false;
    if (plato == null) { return; }
    if (plato?.id == null) {
      this.itemService.crearPlato(plato);
    } else {
      this.itemService.actualizarPlato(plato);
    }
    this.actualizarIngredientes();
    this.dataPlato = new Plato();
  }

  guardarBebida(bebida: Bebida|null) {
    this.editingBebida = false;
    if (bebida == null) { return; }
    if (bebida?.id == null) {
      this.itemService.crearBebida(bebida);
    } else {
      this.itemService.actualizarBebida(bebida);
    }
    this.actualizarIngredientes();
    this.dataBebida = new Bebida();
  }

  guardarIngrediente(ingrediente: Ingrediente|null) {
    this.editingIngrediente = false;
    if (ingrediente == null) { return; }
    if (ingrediente?.id == null) {
      this.itemService.crearIngrediente(ingrediente);
    } else {
      this.itemService.actualizarIngrediente(ingrediente);
    }
    this.actualizarIngredientes();
    this.dataIngrediente = new Ingrediente();
  }


  
  borrarPlato(item: Item) {
    this.itemService.borrarPlato(item?.id??-1).then(b => this.actualizarIngredientes());
  }

  borrarBebida(item: Item) {
    this.itemService.borrarBebida(item?.id??-1).then(b => this.actualizarIngredientes());
  }

  borrarIngrediente(item: Item) {
    this.itemService.borrarIngrediente(item?.id??-1).then(b => this.actualizarIngredientes());
  }


}
