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
  player: Player;
  Champ: string;


  constructor(private service:ChampionsService,private http: HttpClient) { 
  }


  
  ngOnInit() {
    console.log('Started app');
  }
  
  clickAshe(){
    this.Champ = "Ashe";
    localStorage.setItem('Champion1Name',this.Champ);
    console.log("first champion has been set.")
  }
  clickAnnie(){
    this.Champ = "Currently only Ashe works, since the program is still a prototype.";
  }
  clickGaren(){
    this.Champ = "Currently only Ashe works, since the program is still a prototype.";
  }
  clickZilean(){
    this.Champ = "Currently only Ashe works, since the program is still a prototype.";
  }

} 