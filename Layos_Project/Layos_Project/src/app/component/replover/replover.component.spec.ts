import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReploverComponent } from './replover.component';

describe('ReploverComponent', () => {
  let component: ReploverComponent;
  let fixture: ComponentFixture<ReploverComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReploverComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReploverComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
