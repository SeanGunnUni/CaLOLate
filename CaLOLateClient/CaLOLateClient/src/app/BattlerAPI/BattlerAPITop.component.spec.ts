import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BattlerAPITopComponent } from './BattlerAPITop.component';

describe('BattlerAPITopComponent', () => {
  let component: BattlerAPITopComponent;
  let fixture: ComponentFixture<BattlerAPITopComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BattlerAPITopComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BattlerAPITopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
