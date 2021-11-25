import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Sector } from 'src/app/modelos/mesa.model';
import { Mozo, Turno } from 'src/app/modelos/mozo.model';
import { MesaService } from 'src/app/servicios/mesa.service';
import { MozoService } from 'src/app/servicios/mozo.service';


@Component({
  selector: 'app-mozo',
  templateUrl: './mozo.component.html',
  styleUrls: ['./mozo.component.scss']
})
export class MozoComponent implements OnInit {

  listaMozos: Mozo[] = new Array<Mozo>();
  listaDias: {nombre:string, numero:number}[] = new Array<{nombre:string, numero:number}>();
  listaSectores:Sector[]=new Array<Sector>();
  editing=false;
  mozoData:Mozo =new Mozo();


  constructor(private mozoService: MozoService, private mesaService:MesaService,private route:Router) { 
    
  }

  ngOnInit(): void {
    this.actualizarMozos();
  }

  actualizarMozos() {
    this.listaDias = this.mozoService.obtenerDias();
    this.mozoService.obtenerTodos().then(m=>this.listaMozos=m);
    this.mesaService.obtenerSectores().then(s=>this.listaSectores=s);
  }

  inicioNuevo(){
    this.editing = true;
    this.mozoData =  new Mozo();
  }

  compareSect(sec1:Sector,sec2:Sector) {
    return sec1!=null && sec2!=null && sec1.id==sec2.id;
  }

  compareDia(dia1:number,dia2:number) {
    return dia1==dia2;
  }

  agregarTurno(mozo: Mozo){
    mozo.turnos.push(new Turno());
  }
 borrarTurno(mozo: Mozo, turno: Turno){
    mozo.turnos=mozo.turnos.filter(t=>t.id!=turno.id);
  }

  inicioEdit(mozo:Mozo|null){
    this.editing = true;
    const id = mozo?.id??-1;
    this.mozoService.obtenerMozo(id).then(m=>this.mozoData= m??new Mozo());
  }

  guardar(){
    this.editing = false;
    if(this.mozoData?.id==null){
    this.mozoService.crearMozo(this.mozoData);
  }else {
    this.mozoService.actualizarMozo(this.mozoData);
  }

    this.mozoData = new Mozo();
  }

  borrarMozo(mozo:Mozo|null){
    if(confirm("Seguro que queres borrar "+ mozo?.nombre??""+"?")) {
    this.mozoService.borrarMozo(mozo?.id??-1).then(_=>this.actualizarMozos());
    }
  } 

}
