import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {ProduseService} from "../../../services/produse.service";
import {AdminService} from "../../../services/admin.service";
import {AbstractControl, FormControl, FormGroup} from "@angular/forms";
import {MatDialog} from "@angular/material/dialog";
import {ViewCosComponent} from "../../shared/view-cos/view-cos.component";

@Component({
  selector: 'app-produs',
  templateUrl: './produs.component.html',
  styleUrls: ['./produs.component.scss']
})
export class ProdusComponent implements OnInit {
  public user: any;
  public subscription: any;
  public id = 0;
  public userId = 0;
  public produs: any;
  public comentarii = [];
  public CosProdusForm: FormGroup = new FormGroup( {
    cantitate: new FormControl(1)
  });

  public produsForm: FormGroup = new FormGroup({
    id: new FormControl(localStorage.getItem('produs_id')),
    denumire: new FormControl(localStorage.getItem('produs_denumire')),
    pret: new FormControl(localStorage.getItem('pret')),
    url_poza: new FormControl(localStorage.getItem('url_poza'))
  });

  public upcom: FormGroup = new FormGroup({
    updcom: new FormControl("")
  })

  public Comentariu: FormGroup = new FormGroup( {
    com: new FormControl(''),
    username: new FormControl(''),
    id_produs: new FormControl(0),
  });
  public User: any;

  constructor(
    private route: ActivatedRoute,
    private produseService: ProduseService,
    private adminService: AdminService,
    public dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.subscription = this.route.params.subscribe(
      params => {
        this.id = +params['id'];
        if( this.id ){
          this.getProdus();
        }
      });
    this.user = localStorage.getItem('Username')
    this.adminService.getUser(this.user).subscribe(
      (result) => {
        this.userId = result['id'];
      },
      (error) => {
        console.error(error);
      }
    )
    this.adminService.getComentarii(this.id).subscribe(
      (result) => {
        this.comentarii = result;
        console.log(result);
      },
      (error) => {
        console.error(error);
      }
    )

  }


  public getProdus(): void{
    this.produseService.getProdusById(this.id).subscribe(
      (result) => {
        console.log(result);
        this.produs = result
      },
      (error) => {
        console.error(error);
      }
    )
  }
  get cantitate(): AbstractControl{
    return <AbstractControl>this.CosProdusForm.get('cantitate');
  }
  get updcom(): AbstractControl{
    return <AbstractControl>this.upcom.get('updcom');
  }


  public postcosprodus(): void{
    let chestie = {
      userId : this.userId,
      produsId : this.id,
      cantitate : this.cantitate.value
    }

    this.adminService.deleteProdusbyProdusId(chestie['produsId']).subscribe(
      (result) => {
        console.log(result);
        window.location.reload();
      },
      (error) => {
        console.error(error);
      }
    )

    this.adminService.postCosProdus(chestie).subscribe(
      (result) => {
        console.log(result);
        alert('Bid successful');

      },
      (error) => {
        console.error(error);
      }
    )
    this.produs.pret = this.produs.pret * 1.1;
    localStorage.setItem('pret', this.produs['pret']);
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

  public openCos(): void{
    this.dialog.open(ViewCosComponent);
  }
  public cos(): void{
    this.openCos();
  }

  get com(): AbstractControl{
    return <AbstractControl>this.Comentariu.get('com');
  }

  public post_comentariu(): void{
    this.Comentariu.patchValue({
      username: localStorage.getItem('Username'),
      id_produs: this.id,
    })
    this.adminService.createComentariu(this.Comentariu.value).subscribe(
      (result) => {
        console.log(result);
        window.location.reload();
      },
      (error) => {
        console.error(error);
      }
    )
  }

  public deleteCom(comentariu: any): void{
    this.adminService.deleteComentariu(comentariu['id']).subscribe(
      (result) => {
        console.log(result);
        window.location.reload();
      },
      (error) => {
        console.error(error);
      }
    )
  }

  public update_comentariu(comentariu: any): void{
    comentariu['com'] = this.upcom.get('updcom')?.value
    this.adminService.updateComentariu(comentariu).subscribe(
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
