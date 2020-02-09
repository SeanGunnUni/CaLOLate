import { Component, OnInit } from '@angular/core';
import { ChampionsService } from 'src/app/champions.service';
import { Player } from 'src/app/interfaces/PlayerElement';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-battler',
  templateUrl: './battler.component.html',
  styleUrls: ['./battler.component.css']
})
export class BattlerComponent implements OnInit {
  champLevel ="";
  champHealtPer = "";
  championInformationHealthForm: FormGroup;
  championInformationLevelForm: FormGroup;
  constructor(private fb: FormBuilder,private service:ChampionsService,private player2:Player,private http: HttpClient) { 
    player2.name = "";
    this.championInformationHealthForm = fb.group({
      champ2Heath: ['', Validators.maxLength[3]]
    })
    this.championInformationLevelForm = fb.group({
      champ2Level: ['', Validators.maxLength[2]]
    })
  }
  
  Champ2 = "";
  ngOnInit() {
  }
  public listChampVSLevel: Array<string> = ["1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18"];
  public listChampVSHealthPercentage: Array<string> = ["1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18",
  "19", "20", "21", "22", "23", "24","25", "26", "27", "28", "29", "30","31", "32", "33", "34", "35", "36",
  "37", "38", "39", "40", "41", "42","43", "44", "45", "46", "47", "48","49", "50", "51", "52", "53", "54",
  "55", "56", "57", "58", "59", "60","61", "62", "63", "64", "65", "66","67", "68", "69", "70", "71", "72",
  "73", "74", "75", "76", "77", "78","79", "80", "81", "82", "83", "84","85", "86", "87", "88", "89", "90",
  "91", "92", "93", "94", "95", "96","97", "98", "99", "100"];
  public listItemsChampLevel: Array<string> = ["1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18"];
  public listItemsBattlerLength: Array<string> = ["10 seconds", "20 seconds", "30 seconds", "40 seconds"];
  battlePlayerOneAnswer(){
    localStorage.setItem('PartChamp2PickAnswered','true');
  }
  clickAshe2(){
    this.Champ2 = "Ashe";
     this.player2.name = this.Champ2;
     this.service.updatePlayer2Create(this.player2);
     localStorage.setItem('Champion2Name',this.player2.name);
     this.service.getAllinformationAboutChampion2();
     localStorage.setItem('PartChamp2PickAnswered','false');
     localStorage.setItem('PartChamp2Answered','true');
  }
  clickAnnie2(){
    this.Champ2 = "Annie";
     this.player2.name = this.Champ2;
     this.service.updatePlayer2Create(this.player2);
     localStorage.setItem('Champion2Name',this.player2.name);
     this.service.getAllinformationAboutChampion2();
     localStorage.setItem('PartChamp2PickAnswered','false');
     localStorage.setItem('PartChamp2Answered','true');
  }
  clickGaren2(){
    this.Champ2 = "Garen";
     this.player2.name = this.Champ2;
     this.service.updatePlayer2Create(this.player2);
     localStorage.setItem('Champion2Name',this.player2.name);
     this.service.getAllinformationAboutChampion2();
     localStorage.setItem('PartChamp2PickAnswered','false');
     localStorage.setItem('PartChamp2Answered','true');
  }
  clickZilean2(){
    this.Champ2 = "Zilean";
     this.player2.name = this.Champ2;
     this.service.updatePlayer2Create(this.player2);
     localStorage.setItem('Champion2Name',this.player2.name);
     this.service.getAllinformationAboutChampion2();
     localStorage.setItem('PartChamp2PickAnswered','false');
     localStorage.setItem('PartChamp2Answered','true');
  }
  battlePartThreeAnswer(){
    this.champLevel = this.championInformationLevelForm.value;
    this.champHealtPer = this.championInformationHealthForm.value;
    this.player2.level = Number(this.champLevel);
    this.player2.healthPer = Number(this.champHealtPer);
    this.service.updatePlayer2Level(this.player2.level);
    this.service.updatePlayer2HealthPer(this.player2.healthPer);
    localStorage.setItem('Champion2Level',String(this.player2.level));
    localStorage.setItem('Champion2HealthPer',String(this.player2.healthPer));
  }

  get editChamp2Pick(){
    return !!localStorage.getItem('PartChamp2PickAnswered');
  }
  get editedPartTwo(){
    return !!localStorage.getItem('PartChamp2Answered');
  }
  get editedFinal(){
    return !!localStorage.getItem('Part2Answered');
  }
}
