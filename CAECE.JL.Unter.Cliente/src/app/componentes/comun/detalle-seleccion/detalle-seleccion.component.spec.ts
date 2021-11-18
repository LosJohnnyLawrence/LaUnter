import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleSeleccionComponent } from './detalle-seleccion.component';

describe('DetalleSeleccionComponent', () => {
  let component: DetalleSeleccionComponent;
  let fixture: ComponentFixture<DetalleSeleccionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalleSeleccionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalleSeleccionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
