import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ProduseService {

  public url = 'https://localhost:5001/api/Produs'
  constructor(
    public http: HttpClient,
  ) { }

  public getAllProduse(): Observable<any>{
    return this.http.get(`${this.url}`)
  }

  public getProdusById(id: any): Observable<any>{
    return this.http.get(`${this.url}/${id}`)
  }
}
