import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditProdusComponent } from './add-edit-produs.component';

describe('AddEditProdusComponent', () => {
  let component: AddEditProdusComponent;
  let fixture: ComponentFixture<AddEditProdusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditProdusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditProdusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
