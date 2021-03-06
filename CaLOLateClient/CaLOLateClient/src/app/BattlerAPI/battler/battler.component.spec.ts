import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BattlerComponent } from './battler.component';

describe('BattlerComponent', () => {
  let component: BattlerComponent;
  let fixture: ComponentFixture<BattlerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BattlerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BattlerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
