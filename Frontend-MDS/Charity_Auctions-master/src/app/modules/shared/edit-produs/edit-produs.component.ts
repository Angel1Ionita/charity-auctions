import { Component, OnInit } from '@angular/core';
import {AdminService} from "../../../services/admin.service";
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";

@Component({
  selector: 'app-edit-produs',
  templateUrl: './edit-produs.component.html',
  styleUrls: ['./edit-produs.component.scss']
})
export class EditProdusComponent implements OnInit {
  public produsForm: FormGroup = new FormGroup({
    id: new FormControl(localStorage.getItem('produs_id')),
    denumire: new FormControl(localStorage.getItem('produs_denumire')),
    pret: new FormControl(localStorage.getItem('pret')),
    url_poza: new FormControl(localStorage.getItem('url_poza'))
  });
  constructor(
    private adminService: AdminService,
  ) { }

  //getters
  get id(): AbstractControl{
    return <AbstractControl>this.produsForm.get('id');
  }
  get name(): AbstractControl{
    return <AbstractControl>this.produsForm.get('denumire');
  }
  get pret(): AbstractControl{
    return <AbstractControl>this.produsForm.get('pret');
  }
  get url_poza(): AbstractControl{
    return <AbstractControl>this.produsForm.get('url_poza');
  }
  get poster_name(): AbstractControl{
    return <AbstractControl>this.produsForm.get('poster_name');
  }
  get charity_name(): AbstractControl{
    return <AbstractControl>this.produsForm.get('charity_name');
  }


  ngOnInit(): void {

  }
  public editProdus(): void{
    this.adminService.editProdus(this.produsForm.value).subscribe(
      (result) => {
        console.log(result);
        window.location.reload();
      },
      (error) => {
        console.error(error);
      }
    )
  }
}
