import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddEditProdusComponent } from './add-edit-produs/add-edit-produs.component';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {MatButtonModule} from "@angular/material/button";
import { EditProdusComponent } from './edit-produs/edit-produs.component';
import { AddEditUserComponent } from './add-edit-user/add-edit-user.component';
import { ViewCosComponent } from './view-cos/view-cos.component';
import {MaterialModule} from "../material/material.module";
import {MatTableModule} from "@angular/material/table";



@NgModule({
  declarations: [
    AddEditProdusComponent,
    EditProdusComponent,
    AddEditUserComponent,
    ViewCosComponent,
  ],
  imports: [
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    MatButtonModule,
    MaterialModule,
    MatTableModule,
    FormsModule
  ],
  entryComponents: [
    AddEditProdusComponent
  ]
})
export class SharedModule { }
