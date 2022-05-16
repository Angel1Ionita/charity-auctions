import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AuthGuard} from "./auth.guard";

const routes: Routes = [
  {
    path: '',
    canActivate: [AuthGuard],
    children: [
      {
        path: '',
        loadChildren: () => import('src/app/modules/admin/admin.module').then( a => a.AdminModule ),
      }
    ]
  },
  {
    path: '',
    loadChildren: () => import('src/app/modules/produse/produse.module').then(a => a.ProduseModule),
  },
  {
    path: 'login',
    loadChildren: () => import('src/app/modules/auth/auth.module').then(a => a.AuthModule),
  },
  {
    path: '',
    loadChildren: () => import('src/app/modules/admin/admin.module').then(a => a.AdminModule)
  },
  {
    path: '',
    loadChildren: () => import('src/app/modules/contact/contact.module').then(a => a.ContactModule),
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
