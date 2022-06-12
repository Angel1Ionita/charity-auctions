import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProduseRoutingModule } from './produse-routing.module';
import { ProduseComponent } from './produse/produse.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import { ProdusComponent } from './produs/produs.component';
import {MatIconModule} from "@angular/material/icon";
import {MatInputModule} from "@angular/material/input";


@NgModule({
  declarations: [
    ProduseComponent,
    ProdusComponent
  ],
    imports: [
        CommonModule,
        ProduseRoutingModule,
        ReactiveFormsModule,
        MatIconModule,
        FormsModule,
        MatInputModule
    ]
})
export class ProduseModule { }
