import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {DataService} from "../../../services/data.service";
import {MatDialog} from "@angular/material/dialog";
import {AddEditUserComponent} from "../../shared/add-edit-user/add-edit-user.component";
import {AdminService} from "../../../services/admin.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup = new FormGroup( {
    username: new FormControl(''),
    password: new FormControl(''),
  });
  public User: any;
  constructor(
    private router: Router,
    private dataService: DataService,
    public dialog: MatDialog,
    private adminService: AdminService
  ) { }

  //getters
  get username(): AbstractControl{
    return <AbstractControl>this.loginForm.get('username');
  }
  get password(): AbstractControl{
    return <AbstractControl>this.loginForm.get('password');
  }

  ngOnInit(): void {
  }

  public login(): void{
    this.adminService.getUser(this.username.value).subscribe(
      (result) => {
        this.User = result
        if( this.User['parola'] == this.password.value ){
          if( this.User['tip'] == 'User' ){
            localStorage.setItem('Role', 'User');
            localStorage.setItem('Username', this.username.value);
            this.router.navigate(['/produse']);
          }
          else{
            localStorage.setItem('Role', 'Admin');
            localStorage.setItem('Username', this.username.value);
            this.router.navigate(['/admin']);
          }
        }
        else{
          alert("Parola incorecta!")
        }
      },
      (error) => {
        console.error(error);
        alert('Utilizatorul nu exita');
      })
  }

  public openModal(): void{
    this.dialog.open(AddEditUserComponent)
  }

  public openUser(): void{
    this.openModal();
  }



}
