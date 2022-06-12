import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCosComponent } from './view-cos.component';

describe('ViewCosComponent', () => {
  let component: ViewCosComponent;
  let fixture: ComponentFixture<ViewCosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewCosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
