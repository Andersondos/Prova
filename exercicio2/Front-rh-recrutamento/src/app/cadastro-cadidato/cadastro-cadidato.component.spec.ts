import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroCadidatoComponent } from './cadastro-cadidato.component';

describe('CadastroCadidatoComponent', () => {
  let component: CadastroCadidatoComponent;
  let fixture: ComponentFixture<CadastroCadidatoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastroCadidatoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroCadidatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
