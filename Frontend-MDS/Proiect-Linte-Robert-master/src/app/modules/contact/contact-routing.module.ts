import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from "../auth/login/login.component";
import {ContactComponent} from "./contact/contact.component";

const routes: Routes = [
  {
    path: '',
    redirectTo: 'contact'
  },
  {
    path: 'contact',
    component: ContactComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactRoutingModule { }
