import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogoAccionComponent } from './dialogo-accion.component';

describe('DialogoAccionComponent', () => {
  let component: DialogoAccionComponent;
  let fixture: ComponentFixture<DialogoAccionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogoAccionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogoAccionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
