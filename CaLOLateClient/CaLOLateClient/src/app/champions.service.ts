import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Player} from './interfaces/PlayerElement';


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
  
  updatePlayer1Create(player : Player){
    return this.http.put<void>('http://localhost:49944/api/SetPlayer1/'+ player.name,
    name);
  }

  updatePlayer2Create(player : Player){
    return this.http.put<void>('http://localhost:49944/api/SetPlayer2/'+ player.name,
    name);
  }

}
