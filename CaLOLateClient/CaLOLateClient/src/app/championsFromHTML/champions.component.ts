import { Component, OnInit , Injectable, Input} from '@angular/core';
import { ChampionsService } from '../champions.service';
import { NoopAnimationPlayer } from '@angular/animations';
import {Player} from '../interfaces/PlayerElement';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-champions',
  templateUrl: './champions.component.html',
  styleUrls: ['./champions.component.css']

})


@Injectable()
export class ChampionsComponent implements OnInit {


  constructor(private service:ChampionsService,private player:Player,private http: HttpClient) { 
    player.name = "";
  }
  title = "the title";
  Champ = "";

  
  ngOnInit() {
    console.log('Started app');
  }
  
  clickAshe(){
    this.Champ = "Ashe";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.getAllinformationAboutChampion();
  }
  clickAnnie(){
    this.Champ = "Annie";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.getAllinformationAboutChampion();
  }
  clickGaren(){
    this.Champ = "Garen";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.getAllinformationAboutChampion();
  }
  clickZilean(){
    this.Champ = "Zilean";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.getAllinformationAboutChampion();
  }

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

