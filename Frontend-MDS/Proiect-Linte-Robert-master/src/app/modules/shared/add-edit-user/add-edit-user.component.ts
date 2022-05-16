import { Component, OnInit } from '@angular/core';
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {AdminService} from "../../../services/admin.service";

@Component({
  selector: 'app-add-edit-user',
  templateUrl: './add-edit-user.component.html',
  styleUrls: ['./add-edit-user.component.scss']
})
export class AddEditUserComponent implements OnInit {

  public userForm: FormGroup = new FormGroup({
    nume: new FormControl(''),
    adresa_email: new FormControl(''),
    parola: new FormControl(''),
    tip: new FormControl('User')
  });

  constructor(
    private adminService: AdminService,
  ) { }

  //getters
  get username(): AbstractControl{
    return <AbstractControl>this.userForm.get('nume');
  }
  get adresa_email(): AbstractControl{
    return <AbstractControl>this.userForm.get('adresa_email');
  }
  get parola(): AbstractControl{
    return <AbstractControl>this.userForm.get('parola');
  }

  ngOnInit(): void {
  }

  public addUser(): void{
    this.adminService.addUser(this.userForm.value).subscribe(
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
