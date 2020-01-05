import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BattlerAPIBotComponent } from './BattlerAPIBot.component';

describe('BattlerAPIBotComponent', () => {
  let component: BattlerAPIBotComponent;
  let fixture: ComponentFixture<BattlerAPIBotComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BattlerAPIBotComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BattlerAPIBotComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});