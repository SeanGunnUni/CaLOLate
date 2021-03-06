import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Player } from './interfaces/PlayerElement';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ChampionsService {

  get filedPart1() {
    return !!localStorage.getItem('Part1Answered');
  }

   baseUrl: string = 'http://localhost:49944/battler/';
  constructor(private http: HttpClient) {
    
    }



  updatePlayer1Create(player1: Player) {
    return this.http.put(this.baseUrl+'SetPlayer1/' + player1.name,
      player1.name);
  }

  updatePlayer2Create(player2: Player) {
    return this.http.put(this.baseUrl+'SetPlayer2/' + player2.name,
      player2.name);
  }

  updatePlayer1Level(player1: Player) {
    return this.http.put(this.baseUrl+'SetChamp1Level/' + player1.level,
      player1.level);
  }

  updatePlayer2Level(player2: Player) {
    return this.http.put(this.baseUrl+'SetChamp2Level/' + player2.level,
      player2.level);
  }

  updatePlayer2HealthPer(player2: Player) {
    return this.http.put(this.baseUrl+'SetChamp2HealthPer/' + player2.healthPer,
      player2.healthPer);
  }

  updatePlayer1Abilty1LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty1Champion1/' + 1, 1);
  }

  updatePlayer1Abilty2LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty2Champion1/' + 1, 1);
  }

  updatePlayer1Abilty3LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty3Champion1/' + 1, 1);
  }

  updatePlayer1Abilty4LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty4Champion1/' + 1, 1);
  }

  updatePlayer2Abilty1LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty1Champion2/' + 1, 1);
  }

  updatePlayer2Abilty2LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty2Champion2/' + 1, 1);
  }

  updatePlayer2Abilty3LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty3Champion2/' + 1, 1);
  }

  updatePlayer2Abilty4LevelDown() {
    return this.http.put(this.baseUrl+'LevelDownAbilty4Champion2/' + 1, 1);
  }

  updatePlayer1Abilty1LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty1Champion1/' + 1, 1);
  }

  updatePlayer1Abilty2LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty2Champion1/' + 1, 1);
  }

  updatePlayer1Abilty3LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty3Champion1/' + 1, 1);
  }

  updatePlayer1Abilty4LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty4Champion1/' + 1, 1);
  }

  updatePlayer2Abilty1LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty1Champion2/' + 1, 1);
  }

  updatePlayer2Abilty2LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty2Champion2/' + 1, 1);
  }

  updatePlayer2Abilty3LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty3Champion2/' + 1, 1);
  }

  updatePlayer2Abilty4LevelUp() {
    return this.http.put(this.baseUrl+'LevelUpAbilty4Champion2/' + 1, 1);
  }
  ////

  updatePlayer1Item1(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem1Champ1/' + player1.item1, player1.item1);
  }

  updatePlayer1Item2(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem2Champ1/' + player1.item2, player1.item2);
  }

  updatePlayer1Item3(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem3Champ1/' + player1.item3, player1.item3);
  }

  updatePlayer1Item4(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem4Champ1/' + player1.item4, player1.item4);
  }

  updatePlayer1Item5(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem5Champ1/' + player1.item5, player1.item5);
  }

  updatePlayer1Item6(player1: Player) {
    return this.http.put(this.baseUrl+'SetItem6Champ1/' + player1.item6, player1.item6);
  }

  ////

  updatePlayer2Item1(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem1Champ2/' + player2.item1, player2.item1);
  }

  updatePlayer2Item2(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem2Champ2/' + player2.item2, player2.item2);
  }

  updatePlayer2Item3(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem3Champ2/' + player2.item3, player2.item3);
  }

  updatePlayer2Item4(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem4Champ2/' + player2.item4, player2.item4);
  }

  updatePlayer2Item5(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem5Champ1/' + player2.item5, player2.item5);
  }

  updatePlayer2Item6(player2: Player) {
    return this.http.put(this.baseUrl+'SetItem6Champ1/' + player2.item6, player2.item6);
  }

  updateFinalAnswer() {
    return this.http.get(this.baseUrl+'GetFinalAnswer/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('FinalAnswer', data.toString());
    })
  }

  get IfWinInformation() {
    return localStorage.getItem('FinalAnswer');
  }
  //
  getAllinformationAboutChampion() {
    this.Champ1Health();
    this.Champ1AD();
    this.Champ1AP();
    this.Champ1Mana();
    this.Champ1Abilty1Des();
    this.Champ1Abilty2Des();
    this.Champ1Abilty3Des();
    this.Champ1Abilty4Des();
    this.Champ1Abilty5Des();
  }
  get getChampion1Name() {
    return localStorage.getItem('Champion1Name');
  }
  get getChamp1Health() {
    return localStorage.getItem('Champion1Health');
  }
  get getChamp1Mana() {
    return localStorage.getItem('Champion1Mana');
  }
  get getChamp1AbiltyPower() {
    return localStorage.getItem('Champion1AP');
  }
  get getChamp1AttackDamage() {
    return localStorage.getItem('Champion1AD');
  }
  get getPassiveInformation() {
    return localStorage.getItem('Champion1PassiveInfo');
  }
  get getAbilty1Information() {
    return localStorage.getItem('Champion1Abilty1Info');
  }
  get getAbilty2Information() {
    return localStorage.getItem('Champion1Abilty2Info');
  }
  get getAbilty3Information() {
    return localStorage.getItem('Champion1Abilty3Info');
  }
  get getUltimateInformation() {
    return localStorage.getItem('Champion1UltiInfo');
  }
  get getItem1Champ1Information() {
    return localStorage.getItem('Champion1Item1Info');
  }
  get getItem2Champ1Information() {
    return localStorage.getItem('Champion1Item2Info');
  }
  get getItem3Champ1Information() {
    return localStorage.getItem('Champion1Item3Info');
  }
  get getItem4Champ1Information() {
    return localStorage.getItem('Champion1Item4Info');
  }
  get getItem5Champ1Information() {
    return localStorage.getItem('Champion1Item5Info');
  }
  get getItem6Champ1Information() {
    return localStorage.getItem('Champion1Item6Info');
  }
  get getAbilty1Level() {
    return localStorage.getItem('Champion1Abilty1Level');
  }
  get getAbilty2Level() {
    return localStorage.getItem('Champion1Abilty2Level');
  }
  get getAbilty3Level() {
    return localStorage.getItem('Champion1Abilty3Level');
  }
  get getAbilty4Level() {
    return localStorage.getItem('Champion1Abilty4Level');
  }
  get getAbilty5Level() {
    return localStorage.getItem('Champion1Abilty5Level');
  }
  get getAbilty6Level() {
    return localStorage.getItem('Champion1Abilty6Level');
  }
  get getItem1Champ1() {
    return localStorage.getItem('Champion1Item1');
  }
  get getItem2Champ1() {
    return localStorage.getItem('Champion1Item2');
  }
  get getItem3Champ1() {
    return localStorage.getItem('Champion1Item3');
  }
  get getItem4Champ1() {
    return localStorage.getItem('Champion1Item4');
  }
  get getItem5Champ1() {
    return localStorage.getItem('Champion1Item5');
  }
  get getItem6Champ1() {
    return localStorage.getItem('Champion1Item6');
  }

  Champ1Health() {
    localStorage.setItem('Champion1Health', "0");
    return this.http.get(this.baseUrl+'GetChamp1Health/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1Health', data.toString());
    })
  }

  Champ1Mana() {
    localStorage.setItem('Champion1Mana', "0");
    return this.http.get(this.baseUrl+'GetChamp1Mana/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1Mana', data.toString());
    })
  }

  Champ1AP() {
    localStorage.setItem('Champion1AP', "0");
    return this.http.get(this.baseUrl+'GetChamp1AP/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1AP', data.toString());
    })
  }

  Champ1AD() {
    localStorage.setItem('Champion1AD', "0");
    return this.http.get(this.baseUrl+'GetChamp1AD/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1AD', data.toString());
    })
  }

  Champ1Abilty1Des() {
    localStorage.setItem('Champion1PassiveInfo', "none");
    return this.http.get(this.baseUrl+'GetChamp1Abilty1Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1PassiveInfo', data.toString());
    })
  }

  Champ1Abilty2Des() {
    localStorage.setItem('Champion1Abilty1Info', "none");
    return this.http.get(this.baseUrl+'GetChamp1Abilty2Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1Abilty1Info', data.toString());
    })
  }

  Champ1Abilty3Des() {
    localStorage.setItem('Champion1Abilty2Info', "none");
    return this.http.get(this.baseUrl+'GetChamp1Abilty3Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1Abilty2Info', data.toString());
    })
  }

  Champ1Abilty4Des() {
    localStorage.setItem('Champion1Abilty3Info', "none");
    return this.http.get(this.baseUrl+'GetChamp1Abilty4Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1Abilty3Info', data.toString());
    })
  }

  Champ1Abilty5Des() {
    localStorage.setItem('Champion1UltiInfo', "none");
    return this.http.get(this.baseUrl+'GetChamp1Abilty5Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion1UltiInfo', data.toString());
    })
  }
  //////////////////////////////////
  getAllinformationAboutChampion2() {
    this.Champ2Health();
    this.Champ2AD();
    this.Champ2AP();
    this.Champ2Mana();
    this.Champ2Abilty1Des();
    this.Champ2Abilty2Des();
    this.Champ2Abilty3Des();
    this.Champ2Abilty4Des();
    this.Champ2Abilty5Des();
  }
  get getChamp2Health() {
    return localStorage.getItem('Champion2Health');
  }
  get getChamp2Mana() {
    return localStorage.getItem('Champion2Mana');
  }
  get getChamp2AbiltyPower() {
    return localStorage.getItem('Champion2AP');
  }
  get getChamp2AttackDamage() {
    return localStorage.getItem('Champion2AD');
  }
  get getChamp2PassiveInformation() {
    return localStorage.getItem('Champion2PassiveInfo');
  }
  get getChamp2Abilty1Information() {
    return localStorage.getItem('Champion2Abilty1Info');
  }
  get getChamp2Abilty2Information() {
    return localStorage.getItem('Champion2Abilty2Info');
  }
  get getChamp2Abilty3Information() {
    return localStorage.getItem('Champion2Abilty3Info');
  }
  get getChamp2UltimateInformation() {
    return localStorage.getItem('Champion2UltiInfo');
  }
  get getItem1Champ2Information() {
    return localStorage.getItem('Champion2Item1Info');
  }
  get getItem2Champ2Information() {
    return localStorage.getItem('Champion2Item2Info');
  }
  get getItem3Champ2Information() {
    return localStorage.getItem('Champion2Item3Info');
  }
  get getItem4Champ2Information() {
    return localStorage.getItem('Champion2Item4Info');
  }
  get getItem5Champ2Information() {
    return localStorage.getItem('Champion2Item5Info');
  }
  get getItem6Champ2Information() {
    return localStorage.getItem('Champion2Item6Info');
  }
  get getItem1Champ2() {
    return localStorage.getItem('Champion2Item1');
  }
  get getItem2Champ2() {
    return localStorage.getItem('Champion2Item2');
  }
  get getItem3Champ2() {
    return localStorage.getItem('Champion2Item3');
  }
  get getItem4Champ2() {
    return localStorage.getItem('Champion2Item4');
  }
  get getItem5Champ2() {
    return localStorage.getItem('Champion2Item5');
  }
  get getItem6Champ2() {
    return localStorage.getItem('Champion2Item6');
  }


  Champ2Health() {
    localStorage.setItem('Champion2Health', "0");
    return this.http.get(this.baseUrl+'GetChamp2Health/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2Health', data.toString());
    })
  }

  Champ2Mana() {
    localStorage.setItem('Champion2Mana', "0");
    return this.http.get(this.baseUrl+'GetChamp2Mana/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2Mana', data.toString());
    })
  }

  Champ2AP() {
    localStorage.setItem('Champion2AP', "0");
    return this.http.get(this.baseUrl+'GetChamp2AP/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2AP', data.toString());
    })
  }

  Champ2AD() {
    localStorage.setItem('Champion2AD', "0");
    return this.http.get(this.baseUrl+'GetChamp2AD/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2AD', data.toString());
    })
  }

  Champ2Abilty1Des() {
    localStorage.setItem('Champion2PassiveInfo', "none");
    return this.http.get(this.baseUrl+'GetChamp2Abilty1Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2PassiveInfo', data.toString());
    })
  }

  Champ2Abilty2Des() {
    localStorage.setItem('Champion2Abilty1Info', "none");
    return this.http.get(this.baseUrl+'GetChamp2Abilty2Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2Abilty1Info', data.toString());
    })
  }

  Champ2Abilty3Des() {
    localStorage.setItem('Champion2Abilty2Info', "none");
    return this.http.get(this.baseUrl+'GetChamp2Abilty3Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2Abilty2Info', data.toString());
    })
  }

  Champ2Abilty4Des() {
    localStorage.setItem('Champion2Abilty3Info', "none");
    return this.http.get(this.baseUrl+'GetChamp2Abilty4Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2Abilty3Info', data.toString());
    })
  }

  Champ2Abilty5Des() {
    localStorage.setItem('Champion2UltiInfo', "none");
    return this.http.get(this.baseUrl+'GetChamp2Abilty5Des/').subscribe((data) => {
      console.log('Data -', data);
      localStorage.setItem('Champion2UltiInfo', data.toString());
    })
  }

}



