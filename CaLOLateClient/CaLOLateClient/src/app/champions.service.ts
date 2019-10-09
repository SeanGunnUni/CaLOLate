import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ChampionsService {

  baseUrl: string ='http://localhost:49944/api/champions/';

  constructor(private http: HttpClient) { }

  getAll(){
    return this.http.get(this.baseUrl);
  }
}
