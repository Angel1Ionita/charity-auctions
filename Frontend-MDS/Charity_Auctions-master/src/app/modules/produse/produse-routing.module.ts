import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {ProduseComponent} from "./produse/produse.component";
import {ProdusComponent} from "./produs/produs.component";

const routes: Routes = [
  {
    path: '',
    redirectTo: 'produse',
  },
  {
    path: 'produse',
    component: ProduseComponent
  },
  {
    path: 'produs/:id',
    component: ProdusComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProduseRoutingModule { }
