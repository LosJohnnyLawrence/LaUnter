import { Component, OnInit } from '@angular/core';
import { Mesa, Sector } from 'src/app/modelos/mesa.model';
import { MesaService } from 'src/app/servicios/mesa.service';

@Component({
  selector: 'app-mesa',
  templateUrl: './mesa.component.html',
  styleUrls: ['./mesa.component.scss']
})
export class MesaComponent implements OnInit {
  mesaEditId:number|null=null;
  editing=false;
  mesaData:Mesa = new Mesa();
  listaMesas:Mesa[]=new Array<Mesa>();
  listaSectores:Sector[]=new Array<Sector>();


  constructor(private mesaService:MesaService) { }

  ngOnInit(): void {
    this.acutalizarMesas();
  }

  private acutalizarMesas() {
    this.mesaService.obtenerTodos().then(m=>this.listaMesas=m);
    this.mesaService.obtenerSectores().then(s=>this.listaSectores=s);

  }
  
  inicioNuevo(){
    this.editing = true;
    this.mesaEditId = null;
    this.mesaData = new Mesa();
  }
  compareSect(sec1:Sector,sec2:Sector) {
    return sec1!=null && sec2!=null && sec1.id==sec2.id;
  }

  inicioEdit(mesa:Mesa){
    const id =mesa.id;
    this.editing = true;
    this.mesaEditId = id;
    this.mesaService.obtenerMesa(id).then(m=>this.mesaData=m?? new Mesa());
  }

  borrarMesa(mesa:Mesa){
      if(confirm("Seguro que queres borrar "+mesa.nombre??""+"?")) {
        this.mesaService.borrarMesa(mesa?.id??-1).then(_=>this.acutalizarMesas());
      }
  }

  guardar(){
    this.editing = false;
    if(this.mesaData?.id==null){
    this.mesaService.crearMesa(this.mesaData);
  }else {
    this.mesaService.actualizarMesa(this.mesaData);
  }
    this.acutalizarMesas();
    this.mesaData = new Mesa();
  }

}
