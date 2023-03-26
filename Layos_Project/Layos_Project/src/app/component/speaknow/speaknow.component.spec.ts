import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SpeaknowComponent } from './speaknow.component';

describe('SpeaknowComponent', () => {
  let component: SpeaknowComponent;
  let fixture: ComponentFixture<SpeaknowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SpeaknowComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SpeaknowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});