import {Component, OnDestroy, OnInit} from '@angular/core';
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {Router} from "@angular/router";
import {DataService} from "../../../services/data.service";
import {MatDialog} from "@angular/material/dialog";
import {AdminService} from "../../../services/admin.service";
import {AddEditUserComponent} from "../../shared/add-edit-user/add-edit-user.component";
import {ProduseService} from "../../../services/produse.service";
import {ViewCosComponent} from "../../shared/view-cos/view-cos.component";

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit, OnDestroy {

  public filtre: FormGroup = new FormGroup({
    minim: new FormControl(localStorage.getItem('minim')),
    maxim: new FormControl(localStorage.getItem('maxim')),
  });
  public produse = [];
  public lista = []

  constructor(
    private router: Router,
    private produseService: ProduseService,
    public dialog: MatDialog
  ) { }

  ngOnInit(): void {
    let x = localStorage.getItem('minim');
    let y = localStorage.getItem('maxim');
    this.produseService.getAllProduse().subscribe(
      (result) => {
        this.lista = result;
        if( Number(localStorage.getItem('minim')) == 0 && Number(localStorage.getItem('maxim')) == 0 ) {
          this.produse = this.lista;
        }
        else{
          for( var produs of this.lista ){
            if( Number(produs['pret']) > Number(localStorage.getItem('minim')) && Number(produs['pret']) < Number(localStorage.getItem('maxim')) ){
              this.produse.push(produs);
            }
          }
        }
      },
      (error) => {
        console.error(error);
      });
  }
  ngOnDestroy() {
  }

  //getter

  get minim(): AbstractControl{
    return <AbstractControl>this.filtre.get('minim');
  }
  get maxim(): AbstractControl{
    return <AbstractControl>this.filtre.get('maxim');
  }

  public aplica_filtre(): void{
    localStorage.setItem('minim',this.filtre.value.minim);
    localStorage.setItem('maxim',this.filtre.value.maxim);
    window.location.reload();
  }

  public goToProdusProfile(id: any): void{
    this.router.navigate(['/produs', id])
  }
  public openCos(): void{
    this.dialog.open(ViewCosComponent);
  }
  public cos(): void{
    this.openCos();
  }

}
