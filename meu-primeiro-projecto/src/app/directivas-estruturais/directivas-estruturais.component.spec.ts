import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DirectivasEstruturaisComponent } from './directivas-estruturais.component';

describe('DirectivasEstruturaisComponent', () => {
  let component: DirectivasEstruturaisComponent;
  let fixture: ComponentFixture<DirectivasEstruturaisComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DirectivasEstruturaisComponent]
    });
    fixture = TestBed.createComponent(DirectivasEstruturaisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
