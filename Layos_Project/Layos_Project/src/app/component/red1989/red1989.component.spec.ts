import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Red1989Component } from './red1989.component';

describe('Red1989Component', () => {
  let component: Red1989Component;
  let fixture: ComponentFixture<Red1989Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Red1989Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Red1989Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
