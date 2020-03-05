import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Player} from './interfaces/PlayerElement';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ChampionsService {

  get filedPart1(){
    return !!localStorage.getItem('Part1Answered');
  }

  baseUrl: string ='http://localhost:49944/api/battler/';

  constructor(private http: HttpClient) { }

  

  updatePlayer1Create(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetPlayer1/'+ player1.name,
    player1.name);
  }

  updatePlayer2Create(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetPlayer2/'+ player2.name,
    player2.name);
  }

  updatePlayer1Level(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetChamp1Level/'+ player1.level,
    player1.level);
  }

  updatePlayer2Level(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetChamp2Level/'+ player2.level,
    player2.level);
  }

  updatePlayer2HealthPer(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetChamp2HealthPer/'+ player2.healthPer,
    player2.healthPer);
  }

  updatePlayer1Abilty1LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty1Champion1/'+ 1,1);
  }

  updatePlayer1Abilty2LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty2Champion1/'+ 1,1);
  }

  updatePlayer1Abilty3LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty3Champion1/'+ 1,1);
  }

  updatePlayer1Abilty4LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty4Champion1/'+ 1,1);
  }

  updatePlayer2Abilty1LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty1Champion2/'+ 1,1);
  }

  updatePlayer2Abilty2LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty2Champion2/'+ 1,1);
  }

  updatePlayer2Abilty3LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty3Champion2/'+ 1,1);
  }

  updatePlayer2Abilty4LevelDown(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelDownAbilty4Champion2/'+ 1,1);
  }

  updatePlayer1Abilty1LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty1Champion1/'+ 1,1);
  }

  updatePlayer1Abilty2LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty2Champion1/'+ 1,1);
  }

  updatePlayer1Abilty3LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty3Champion1/'+ 1,1);
  }

  updatePlayer1Abilty4LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty4Champion1/'+ 1,1);
  }

  updatePlayer2Abilty1LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty1Champion2/'+ 1,1);
  }

  updatePlayer2Abilty2LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty2Champion2/'+ 1,1);
  }

  updatePlayer2Abilty3LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty3Champion2/'+ 1,1);
  }

  updatePlayer2Abilty4LevelUp(){
    return this.http.put<void>('http://localhost:49944/battler/api/LevelUpAbilty4Champion2/'+ 1,1);
  }
  ////

  updatePlayer1Item1(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem1Champ1/'+ player1.item1,player1.item1);
  }

  updatePlayer1Item2(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem2Champ1/'+ player1.item2,player1.item2);
  }

  updatePlayer1Item3(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem3Champ1/'+ player1.item3,player1.item3);
  }

  updatePlayer1Item4(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem4Champ1/'+ player1.item4,player1.item4);
  }

  updatePlayer1Item5(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem5Champ1/'+ player1.item5,player1.item5);
  }

  updatePlayer1Item6(player1 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem6Champ1/'+ player1.item6,player1.item6);
  }

  ////

  updatePlayer2Item1(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem1Champ2/'+ player2.item1,player2.item1);
  }

  updatePlayer2Item2(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem2Champ2/'+ player2.item2,player2.item2);
  }

  updatePlayer2Item3(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem3Champ2/'+ player2.item3,player2.item3);
  }

  updatePlayer2Item4(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem4Champ2/'+ player2.item4,player2.item4);
  }

  updatePlayer2Item5(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem5Champ1/'+ player2.item5,player2.item5);
  }

  updatePlayer2Item6(player2 : Player){
    return this.http.put<void>('http://localhost:49944/battler/api/SetItem6Champ1/'+ player2.item6,player2.item6);
  }

  updateFinalAnswer(){
    return this.http.get('http://localhost:49944/battler/api/GetFinalAnswer/').subscribe((data)=>{
      console.log('Data -', data);
      localStorage.setItem('FinalAnswer',data.toString());
    })
  }

  get IfWinInformation(){
    return localStorage.getItem('FinalAnswer');
  }
//
getAllinformationAboutChampion(){
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
get getChampion1Name(){
  return localStorage.getItem('Champion1Name');
}
get getChamp1Health(){
  return localStorage.getItem('Champion1Health');
}
get getChamp1Mana(){
  return localStorage.getItem('Champion1Mana');
}
get getChamp1AbiltyPower(){
  return localStorage.getItem('Champion1AP');
}
get getChamp1AttackDamage(){
  return localStorage.getItem('Champion1AD');
}
get getPassiveInformation(){
  return localStorage.getItem('Champion1PassiveInfo');
}
get getAbilty1Information(){
  return localStorage.getItem('Champion1Ab1Info');
}
get getAbilty2Information(){
  return localStorage.getItem('Champion1Ab2Info');
}
get getAbilty3Information(){
  return localStorage.getItem('Champion1Ab3Info');
}
get getUltimateInformation(){
  return localStorage.getItem('Champion1UltiInfo');
}
get getItem1Champ1Information(){
  return localStorage.getItem('Champion1Item1Info');
}
get getItem2Champ1Information(){
  return localStorage.getItem('Champion1Item2Info');
}
get getItem3Champ1Information(){
  return localStorage.getItem('Champion1Item3Info');
}
get getItem4Champ1Information(){
  return localStorage.getItem('Champion1Item4Info');
}
get getItem5Champ1Information(){
  return localStorage.getItem('Champion1Item5Info');
}
get getItem6Champ1Information(){
  return localStorage.getItem('Champion1Item6Info');
}
get getAbilty1Level(){
  return localStorage.getItem('Champion1Item1Level');
}
get getAbilty2Level(){
  return localStorage.getItem('Champion1Item2Level');
}
get getAbilty3Level(){
  return localStorage.getItem('Champion1Item3Level');
}
get getAbilty4Level(){
  return localStorage.getItem('Champion1Item4Level');
}
get getAbilty5Level(){
  return localStorage.getItem('Champion1Item5Level');
}
get getAbilty6Level(){
  return localStorage.getItem('Champion1Item6Level');
}
get getItem1Champ1(){
  return localStorage.getItem('Champion1Item1');
}
get getItem2Champ1(){
  return localStorage.getItem('Champion1Item2');
}
get getItem3Champ1(){
  return localStorage.getItem('Champion1Item3');
}
get getItem4Champ1(){
  return localStorage.getItem('Champion1Item4');
}
get getItem5Champ1(){
  return localStorage.getItem('Champion1Item5');
}
get getItem6Champ1(){
  return localStorage.getItem('Champion1Item6');
}

Champ1Health(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Health/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Health',data.toString());
  })
}

Champ1Mana(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Mana/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Mana',data.toString());
  })
}

Champ1AP(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1AP/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1AP',data.toString());
  })
}

Champ1AD(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1AD/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1AD',data.toString());
  })
}

Champ1Abilty1Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Abilty1Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1PassiveInfo',data.toString());
  })
}

Champ1Abilty2Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Abilty2Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty1Info',data.toString());
  })
}

Champ1Abilty3Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Abilty3Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty2Info',data.toString());
  })
}

Champ1Abilty4Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Abilty4Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty3Info',data.toString());
  })
}

Champ1Abilty5Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp1Abilty5Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1UltiInfo',data.toString());
  })
}
//////////////////////////////////
getAllinformationAboutChampion2(){
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
get getChamp2Health(){
  return localStorage.getItem('Champion2Health');
}
get getChamp2Mana(){
  return localStorage.getItem('Champion2Mana');
}
get getChamp2AbiltyPower(){
  return localStorage.getItem('Champion2AP');
}
get getChamp2AttackDamage(){
  return localStorage.getItem('Champion2AD');
}
get getChamp2PassiveInformation(){
  return localStorage.getItem('Champion2PassiveInfo');
}
get getChamp2Abilty1Information(){
  return localStorage.getItem('Champion2Ab1Info');
}
get getChamp2Abilty2Information(){
  return localStorage.getItem('Champion2Ab2Info');
}
get getChamp2Abilty3Information(){
  return localStorage.getItem('Champion2Ab3Info');
}
get getChamp2UltimateInformation(){
  return localStorage.getItem('Champion2UltiInfo');
}
get getItem1Champ2Information(){
  return localStorage.getItem('Champion2Item1Info');
}
get getItem2Champ2Information(){
  return localStorage.getItem('Champion2Item2Info');
}
get getItem3Champ2Information(){
  return localStorage.getItem('Champion2Item3Info');
}
get getItem4Champ2Information(){
  return localStorage.getItem('Champion2Item4Info');
}
get getItem5Champ2Information(){
  return localStorage.getItem('Champion2Item5Info');
}
get getItem6Champ2Information(){
  return localStorage.getItem('Champion2Item6Info');
}
get getItem1Champ2(){
  return localStorage.getItem('Champion2Item1');
}
get getItem2Champ2(){
  return localStorage.getItem('Champion2Item2');
}
get getItem3Champ2(){
  return localStorage.getItem('Champion2Item3');
}
get getItem4Champ2(){
  return localStorage.getItem('Champion2Item4');
}
get getItem5Champ2(){
  return localStorage.getItem('Champion2Item5');
}
get getItem6Champ2(){
  return localStorage.getItem('Champion2Item6');
}


Champ2Health(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Health/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Health',data.toString());
  })
}

Champ2Mana(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Mana/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Mana',data.toString());
  })
}

Champ2AP(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2AP/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2AP',data.toString());
  })
}

Champ2AD(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2AD/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2AD',data.toString());
  })
}

Champ2Abilty1Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Abilty1Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2PassiveInfo',data.toString());
  })
}

Champ2Abilty2Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Abilty2Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Abilty1Info',data.toString());
  })
}

Champ2Abilty3Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Abilty3Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Abilty2Info',data.toString());
  })
}

Champ2Abilty4Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Abilty4Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Abilty3Info',data.toString());
  })
}

Champ2Abilty5Des(){
  return this.http.get('http://localhost:49944/battler/api/GetChamp2Abilty5Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2UltiInfo',data.toString());
  })
}

}



