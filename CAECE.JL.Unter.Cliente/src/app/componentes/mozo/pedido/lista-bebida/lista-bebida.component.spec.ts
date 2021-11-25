import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaBebidaComponent } from './lista-bebida.component';

describe('ListaBebidaComponent', () => {
  let component: ListaBebidaComponent;
  let fixture: ComponentFixture<ListaBebidaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListaBebidaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaBebidaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
