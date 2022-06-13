import { Component, OnInit } from '@angular/core';
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {newArray} from "@angular/compiler/src/util";
import {AdminService} from "../../../services/admin.service";

@Component({
  selector: 'app-add-edit-produs',
  templateUrl: './add-edit-produs.component.html',
  styleUrls: ['./add-edit-produs.component.scss']
})
export class AddEditProdusComponent implements OnInit {

  public produsForm: FormGroup = new FormGroup({
    id: new FormControl(0),
    denumire: new FormControl(''),
    pret: new FormControl(0),
    url_poza: new FormControl(''),
    poster_name: new FormControl(''),
    charity_name: new FormControl('')
  });

  constructor(
    private adminService: AdminService,
  ) { }

  //getters
  get name(): AbstractControl{
    return <AbstractControl>this.produsForm.get('denumire');
  }
  get pret(): AbstractControl{
    return <AbstractControl>this.produsForm.get('pret');
  }
  get url_poza(): AbstractControl {
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

  public addProdus(): void{
    this.adminService.addProdus(this.produsForm.value).subscribe(
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
