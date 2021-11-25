import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdicionSelecComponent } from './edicion-selec.component';

describe('EdicionSelecComponent', () => {
  let component: EdicionSelecComponent;
  let fixture: ComponentFixture<EdicionSelecComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EdicionSelecComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EdicionSelecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
