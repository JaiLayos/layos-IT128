import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FolkmoreComponent } from './folkmore.component';

describe('FolkmoreComponent', () => {
  let component: FolkmoreComponent;
  let fixture: ComponentFixture<FolkmoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FolkmoreComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FolkmoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
