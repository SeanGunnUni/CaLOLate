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

  updatePlayer1Level(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetChamp1Level/'+ player1.level,
    level);
  }

  updatePlayer2Level(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetChamp2Level/'+ player2.level,
    level);
  }

  updatePlayer1Abilty1LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty1Champion1/'+ 1,1);
  }

  updatePlayer1Abilty2LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty2Champion1/'+ 1,1);
  }

  updatePlayer1Abilty3LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty3Champion1/'+ 1,1);
  }

  updatePlayer1Abilty4LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty4Champion1/'+ 1,1);
  }

  updatePlayer2Abilty1LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty1Champion2/'+ 1,1);
  }

  updatePlayer2Abilty2LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty2Champion2/'+ 1,1);
  }

  updatePlayer2Abilty3LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty3Champion2/'+ 1,1);
  }

  updatePlayer2Abilty4LevelDown(){
    return this.http.put<void>('http://localhost:49944/api/LevelDownAbilty4Champion2/'+ 1,1);
  }

  updatePlayer1Abilty1LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty1Champion1/'+ 1,1);
  }

  updatePlayer1Abilty2LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty2Champion1/'+ 1,1);
  }

  updatePlayer1Abilty3LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty3Champion1/'+ 1,1);
  }

  updatePlayer1Abilty4LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty4Champion1/'+ 1,1);
  }

  updatePlayer2Abilty1LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty1Champion2/'+ 1,1);
  }

  updatePlayer2Abilty2LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty2Champion2/'+ 1,1);
  }

  updatePlayer2Abilty3LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty3Champion2/'+ 1,1);
  }

  updatePlayer2Abilty4LevelUp(){
    return this.http.put<void>('http://localhost:49944/api/LevelUpAbilty4Champion2/'+ 1,1);
  }
  ////

  updatePlayer1Item1(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem1Champ1/'+ player1.item1,item1);
  }

  updatePlayer1Item2(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem2Champ1/'+ player1.item2,item2);
  }

  updatePlayer1Item3(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem3Champ1/'+ player1.item3,item3);
  }

  updatePlayer1Item4(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem4Champ1/'+ player1.item4,item4);
  }

  updatePlayer1Item5(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem5Champ1/'+ player1.item5,item5);
  }

  updatePlayer1Item6(player1 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem6Champ1/'+ player1.item6,item6);
  }

  ////

  updatePlayer2Item1(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem1Champ2/'+ player2.item1,item1);
  }

  updatePlayer2Item2(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem2Champ2/'+ player2.item2,item2);
  }

  updatePlayer2Item3(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem3Champ2/'+ player2.item3,item3);
  }

  updatePlayer2Item4(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem4Champ2/'+ player2.item4,item4);
  }

  updatePlayer2Item5(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem5Champ1/'+ player2.item5,item5);
  }

  updatePlayer2Item6(player2 : Player){
    return this.http.put<void>('http://localhost:49944/api/SetItem6Champ1/'+ player2.item6,item6);
  }

  getFinalAnswer(){
    return this.http.get('http://localhost:49944/api/GetFinalAnswer/').subscribe((data)=>{
      console.log('Data -', data);
    })
  }

}
