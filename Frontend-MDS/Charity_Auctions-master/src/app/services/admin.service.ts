import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {AbstractControl} from "@angular/forms";

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  public url = 'https://localhost:5001/api/Produs'
  public url2 = 'https://localhost:5001/api/User'
  public url3 = 'https://localhost:5001/api/CosProdus'
  public url4 = 'https://localhost:5001/api/Comentariu'
  public url5 = 'https://localhost:5001/api/CosProdus/User'
  constructor(
    public http: HttpClient,
  ) { }

  public getAllProduse(): Observable<any>{
    return this.http.get(`${this.url}`)
  }
  public getProdus(id: any): Observable<any>{
    return this.http.get(`${this.url}/${id}`)
  }
  public deleteProdus(id: any): Observable<any>{
    return this.http.delete(`${this.url}/${id}`, id);
  }

  public addProdus(produs: any): Observable<any>{
    return this.http.post(`${this.url}`, produs)
  }
  public deleteArticol(id: any): Observable<any>{
    return this.http.delete(`${this.url3}/${id}`)
  }

  public editProdus(produs: any): Observable<any>{
    return this.http.put(`${this.url}`,produs);
  }

  public addUser(user: any): Observable<any>{
    return this.http.post(`${this.url2}`, user)
  }

  public getUser(username: AbstractControl): Observable<any>{
    return this.http.get(`${this.url2}/${username}`)
  }

  public postCosProdus(cosprodus: any): Observable<any>{
    return this.http.post(`${this.url3}`, cosprodus);
  }

  public getCosProdus(user: any): Observable<any>{
    return this.http.get(`${this.url3}/${user}`);
  }

  public updateUser(user: any): Observable<any>{
    return this.http.put(`${this.url2}`, user);
  }

  public updateCant(produs: any): Observable<any>{
    return this.http.put(`${this.url3}`, produs);
  }

  public createComentariu(comentariu: any): Observable<any>{
    return this.http.post(`${this.url4}`, comentariu);
  }
  public getComentarii(id: any): Observable<any>{
    return this.http.get(`${this.url4}/${id}`);
  }
  public deleteComentariu(id: any): Observable<any>{
    return this.http.delete(`${this.url4}/${id}`);
  }
  public updateComentariu(comentariu: any): Observable<any>{
    return this.http.put(`${this.url4}`, comentariu);
  }

  public deleteProdusbyProdusId(produsid: any): Observable<any>{
    return this.http.delete(`${this.url5}/${produsid}`, produsid);
  }
}
