import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BattlerAPICalculatorComponent } from './BattlerAPICalculator.component';

describe('BattlerAPICalculatorComponent', () => {
  let component: BattlerAPICalculatorComponent;
  let fixture: ComponentFixture<BattlerAPICalculatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BattlerAPICalculatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BattlerAPICalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});