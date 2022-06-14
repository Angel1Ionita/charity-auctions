import {Component, OnDestroy, OnInit} from '@angular/core';
import {Router} from "@angular/router";
import {DataService} from "../../../services/data.service";
import {Subscription} from "rxjs";
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {AdminService} from "../../../services/admin.service";
import {MatDialog, MatDialogConfig} from "@angular/material/dialog";
import {AddEditProdusComponent} from "../../shared/add-edit-produs/add-edit-produs.component";
import {EditProdusComponent} from "../../shared/edit-produs/edit-produs.component";
import {ViewCosComponent} from "../../shared/view-cos/view-cos.component";

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit, OnDestroy {

  public subscription: Subscription = new Subscription;
  public loggedUser!: { username: string; password: string; };
  public filtre: FormGroup = new FormGroup({
    minim: new FormControl(''),
    maxim: new FormControl(''),
  });
  public pret_final: FormGroup = new FormGroup({
    pret_nou: new FormControl(0),
  });
  public produse = [];
  public lista = [];

  constructor(
    private router: Router,
    private dataService: DataService,
    private adminService: AdminService,
    public dialog: MatDialog,
  ) { }

  ngOnInit(): void {
    this.subscription = this.dataService.currentUser.subscribe(user => this.loggedUser = user);
    this.adminService.getAllProduse().subscribe(
      (result) => {
        this.produse = result
      },
      (error) => {
        console.error(error);
      })
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  public logout(): void{
    this.router.navigate(['login']);
  }

  public deleteProdus(id: any): void{
    this.adminService.deleteProdus(id).subscribe(
      (result) => {
        console.log(result);
        this.produse = result;
      },
      (error) => {
        console.error(error);
      }
    )
    window.location.reload();
  }

  public openModal(): void{
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = '550px';
    dialogConfig.height = '700px';
    this.dialog.open(AddEditProdusComponent, dialogConfig);
  }

  public openModal1(produs: any): void{
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = '550px';
    dialogConfig.height = '700px';
    this.dialog.open(EditProdusComponent, dialogConfig);
  }

  public addNewProdus(): void{
    this.openModal();
  }

  public editProdus(produs: any): void{
    localStorage.setItem('produs_id', produs['id']);
    localStorage.setItem('produs_denumire', produs['denumire']);
    localStorage.setItem('pret', produs['pret']);
    localStorage.setItem('url_poza', produs['url_poza']);
    localStorage.setItem('poster_name', produs['poster_name']);
    localStorage.setItem('charity_name', produs['charity_name']);
    this.openModal1(produs);
  }
  public openCos(): void{
    this.dialog.open(ViewCosComponent);
  }
  public cos(): void{
    this.openCos();
  }
}
