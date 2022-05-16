import {Component, OnDestroy, OnInit} from '@angular/core';
import {ProduseService} from "../../../services/produse.service";
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {formatNumber} from "@angular/common";
import {
  removeElementFromArrayExpression
} from "@angular/material/schematics/ng-update/migrations/hammer-gestures-v9/remove-array-element";
import {Router} from "@angular/router";
import {ViewCosComponent} from "../../shared/view-cos/view-cos.component";
import {MatDialog} from "@angular/material/dialog";

@Component({
  selector: 'app-produse',
  templateUrl: './produse.component.html',
  styleUrls: ['./produse.component.scss']
})
export class ProduseComponent implements OnInit, OnDestroy {

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
