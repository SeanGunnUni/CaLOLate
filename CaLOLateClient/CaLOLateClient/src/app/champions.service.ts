import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ChampionsService {

  baseUrl: string ='http://localhost:49944/api/battler/';

  constructor(private http: HttpClient) { }
getALL2(){
    return this.http.get(this.baseUrl);
  }
  getAll(){
    return this.http.get(this.baseUrl);
  }
  
}
