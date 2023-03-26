import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FearlessComponent } from './fearless.component';

describe('FearlessComponent', () => {
  let component: FearlessComponent;
  let fixture: ComponentFixture<FearlessComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FearlessComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FearlessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
