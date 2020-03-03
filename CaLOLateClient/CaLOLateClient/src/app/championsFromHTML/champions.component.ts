import { Component, OnInit, Injectable} from '@angular/core';
import { ChampionsService } from '../champions.service';
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
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.service.getAllinformationAboutChampion();
  }
  clickAnnie(){
    this.Champ = "Annie";
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.service.getAllinformationAboutChampion();
  }
  clickGaren(){
    this.Champ = "Garen";
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.service.getAllinformationAboutChampion();
  }
  clickZilean(){
    this.Champ = "Zilean";
    this.player.name = this.Champ;
    this.service.updatePlayer1Create(this.player);
    localStorage.setItem('Champion1Name',this.player.name);
    this.service.getAllinformationAboutChampion();
  }

} 