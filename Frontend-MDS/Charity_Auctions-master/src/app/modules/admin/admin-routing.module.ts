import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {ProduseComponent} from "../produse/produse/produse.component";
import {AppComponent} from "../../app.component";
import {AdminComponent} from "./admin/admin.component";

const routes: Routes = [
  {
    path: '',
    redirectTo: 'admin',
  },
  {
    path: 'admin',
    component: AdminComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
