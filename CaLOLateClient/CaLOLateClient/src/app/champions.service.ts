import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Player} from './interfaces/PlayerElement';


@Injectable({
  providedIn: 'root'
})
export class ChampionsService {

  get filedPart1(){
    return !!localStorage.getItem('Part1Answered');
  }

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


Champ1Health(){
  return this.http.get('http://localhost:49944/api/GetChamp1Health/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Health',data.toString());
  })
}

Champ1Mana(){
  return this.http.get('http://localhost:49944/api/GetChamp1Mana/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Mana',data.toString());
  })
}

Champ1AP(){
  return this.http.get('http://localhost:49944/api/GetChamp1AP/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1AP',data.toString());
  })
}

Champ1AD(){
  return this.http.get('http://localhost:49944/api/GetChamp1AD/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1AD',data.toString());
  })
}

Champ1Abilty1Des(){
  return this.http.get('http://localhost:49944/api/GetChamp1Abilty1Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1PassiveInfo',data.toString());
  })
}

Champ1Abilty2Des(){
  return this.http.get('http://localhost:49944/api/GetChamp1Abilty2Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty1Info',data.toString());
  })
}

Champ1Abilty3Des(){
  return this.http.get('http://localhost:49944/api/GetChamp1Abilty3Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty2Info',data.toString());
  })
}

Champ1Abilty4Des(){
  return this.http.get('http://localhost:49944/api/GetChamp1Abilty4Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1Abilty3Info',data.toString());
  })
}

Champ1Abilty5Des(){
  return this.http.get('http://localhost:49944/api/GetChamp1Abilty5Des/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion1UltiInfo',data.toString());
  })
}



/*Champ2Health(){
  return this.http.get('http://localhost:49944/api/GetChamp2Health/').subscribe((data)=>{
    console.log('Data -', data);
    localStorage.setItem('Champion2Health',data.toString());
  })
}*/
}



