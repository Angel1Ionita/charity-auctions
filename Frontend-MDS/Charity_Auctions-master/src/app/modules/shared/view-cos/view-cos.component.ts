import { Component, OnInit } from '@angular/core';
import {AdminComponent} from "../../admin/admin/admin.component";
import {AdminService} from "../../../services/admin.service";
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-view-cos',
  templateUrl: './view-cos.component.html',
  styleUrls: ['./view-cos.component.scss']

})
export class ViewCosComponent implements OnInit {
  public id : any;
  public cos = [];
  public produse = [];
  public total = 0;
  constructor(
    public adminService: AdminService
  ) { }


  ngOnInit(): void {
    let username : any;
    username = localStorage.getItem('Username');
    this.adminService.getUser(username).subscribe(
      (result) => {
        this.id = result['id'];
        this.adminService.getCosProdus(this.id).subscribe(
          (result) => {
            console.log(result);
            this.cos = result;
          },
          (error) => {
            console.error(error);
          }
        )
        this.adminService.getAllProduse().subscribe(
          (result) => {
            this.produse = result;
            for( let articol of this.cos ){
              for( let produs of this.produse ){
                if( articol['produsId'] == produs['id'] ){
                  this.total = this.total + Number(produs['pret'])*Number(articol['cantitate']);
                }
              }
            }
          },
          (error) => {
            console.error(error);
          }
        )
      },
      (error) => {
        console.error(error);
      }
    )
  }
  public sterge_produs(id: any){
    this.adminService.deleteArticol(id).subscribe(
    (result) =>{
      console.log(result);
      window.location.reload();
    },
    (error) => {
      console.error(error);
    }
    )
  }

  public cantitate: any;
  public update_produs(produs: any): void{
    produs['cantitate'] = this.cantitate;
    this.adminService.updateCant(produs).subscribe(
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
