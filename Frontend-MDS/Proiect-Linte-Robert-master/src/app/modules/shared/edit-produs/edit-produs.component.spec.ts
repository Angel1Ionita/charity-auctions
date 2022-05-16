import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditProdusComponent } from './edit-produs.component';

describe('EditProdusComponent', () => {
  let component: EditProdusComponent;
  let fixture: ComponentFixture<EditProdusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditProdusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditProdusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
