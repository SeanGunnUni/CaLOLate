import { Component, OnInit } from '@angular/core';
import { ChampionsService } from 'src/app/champions.service';
import { PlayerClass } from 'src/app/interfaces/Player';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-battler',
  templateUrl: './battler.component.html',
  styleUrls: ['./battler.component.css']
})

export class BattlerComponent implements OnInit {
  champLevel ="";
  champAbilty1Level ="";
  champAbilty2Level ="";
  champAbilty3Level ="";
  champAbilty4Level ="";
  champAbilty5Level ="";
  champAbilty6Level ="";
  champAbilty1Levelt = 0;
  champAbilty2Levelt = 0;
  champAbilty3Levelt = 0;
  champAbilty4Levelt = 0;
  champAbilty5Levelt = 0;
  champAbilty6Levelt = 0;
  champ1Item1 ="";
  champ1Item2 ="";
  champ1Item3 ="";
  champ1Item4 ="";
  champ1Item5 ="";
  champ1Item6 ="";
  champ2Item1 ="";
  champ2Item2 ="";
  champ2Item3 ="";
  champ2Item4 ="";
  champ2Item5 ="";
  champ2Item6 ="";
  champHealtPer = "";
  championInformationHealthForm: FormGroup;
  championInformationLevelForm: FormGroup;
  player1 = new PlayerClass(); 
  
  player2 = new PlayerClass();
  constructor(private fb: FormBuilder,private service:ChampionsService,private http: HttpClient) { 
    this.championInformationHealthForm = fb.group({
      champ2Health: ['', Validators.maxLength[3]]
    })
    this.championInformationLevelForm = fb.group({
      champ2Level: ['', Validators.maxLength[2]]
    })
  }
  
  Champ2 = "";
  ngOnInit() {
    var nameTemp = localStorage.getItem('Champion1Name');
    this.player1.name = nameTemp;
    this.service.updatePlayer1Create(this.player1);
    this.service.getAllinformationAboutChampion();
    localStorage.setItem('Champion1Level','0');
    localStorage.setItem('Champion2Level','0');
    localStorage.setItem('Champion2HealthPers','0');
    localStorage.setItem('BattleLength','0');
    localStorage.setItem('Champion1Abilty4Level','0');
    localStorage.setItem('Champion1Abilty3Level','0');
    localStorage.setItem('Champion1Abilty2Level','0');
    localStorage.setItem('Champion1Abilty1Level','0');
    localStorage.setItem('Champion1Item1','none');
    localStorage.setItem('Champion1Item2','none');
    localStorage.setItem('Champion1Item3','none');
    localStorage.setItem('Champion1Item4','none');
    localStorage.setItem('Champion1Item5','none');
    localStorage.setItem('Champion1Item6','none');
    localStorage.setItem('Champion2Item1','none');
    localStorage.setItem('Champion2Item2','none');
    localStorage.setItem('Champion2Item3','none');
    localStorage.setItem('Champion2Item4','none');
    localStorage.setItem('Champion2Item5','none');
    localStorage.setItem('Champion2Item6','none');
  }
  public listChampVSLevel: Array<string> = ["0","1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18"];
  public listChampVSHealthPercentage: Array<string> = ["1%", "2%", "3%", "4%", "5%", "6%","7%", "8%", "9%", "10%", "11%", "12%","13%", "14%", "15%", "16%", "17%", "18%",
  "19%", "20%", "21%", "22%", "23%", "24%","25%", "26%", "27%", "28%", "29%", "30%","31%", "32%", "33%", "34%", "35%", "36%",
  "37%", "38%", "39%", "40%", "41%", "42%","43%", "44%", "45%", "46%", "47%", "48%","49%", "50%", "51%", "52%", "53%", "54%",
  "55%", "56%", "57%", "58%", "59%", "60%","61%", "62%", "63%", "64%", "65%", "66%","67%", "68%", "69%", "70%", "71%", "72%",
  "73%", "74%", "75%", "76%", "77%", "78%","79%", "80%", "81%", "82%", "83%", "84%","85%", "86%", "87%", "88%", "89%", "90%",
  "91%", "92%", "93%", "94%", "95%", "96%","97%", "98%", "99%", "100%"];
  public listItemsChampLevel: Array<string> = ["0","1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18"];
  public listItemsBattlerLength: Array<string> = ["10 seconds", "20 seconds", "30 seconds", "40 seconds"];
  public selectedChamp1Level: string = '0';
  public selectedChamp2Level: string = '0';
  public selectedChamp2HealthPer: string = '100%';
  public selectedOverallTime: string = '10 seconds';
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
    localStorage.setItem('Champion1Level', this.selectedChamp1Level);
    this.champHealtPer = this.championInformationHealthForm.value;
    localStorage.setItem('Champion2Level', this.selectedChamp2Level);
    localStorage.setItem('Champion2HealthPers', this.selectedChamp2HealthPer);
    localStorage.setItem('BattleLength', this.selectedOverallTime);
    //this.service.updatePlayer2Level(this.player2.level);
   // this.service.updatePlayer2HealthPer(this.player2.healthPer);
    this.service.updateFinalAnswer();
    localStorage.setItem('Part2Answered','true');
  }
  levelUpAbilty1(){
    this.champAbilty1Level = localStorage.getItem('Champion1Abilty1Level');
    if(Number(this.champAbilty1Level) <6){
      this.service.updatePlayer1Abilty1LevelUp();
      this.champAbilty1Levelt = Number(this.champAbilty1Level) + 1;
      localStorage.setItem('Champion1Abilty1Level',this.champAbilty1Levelt.toString());
    }
  }
  levelUpAbilty2(){
    this.champAbilty2Level = localStorage.getItem('Champion1Abilty2Level');
    if(Number(this.champAbilty2Level) <6){
      this.service.updatePlayer1Abilty2LevelUp();
      this.champAbilty2Levelt = Number(this.champAbilty2Level) + 1;
      localStorage.setItem('Champion1Abilty2Level',this.champAbilty2Levelt.toString());
    }
  }
  levelUpAbilty3(){
    this.champAbilty3Level = localStorage.getItem('Champion1Abilty3Level');
    if(Number(this.champAbilty3Level) <6){
      this.service.updatePlayer1Abilty3LevelUp();
      this.champAbilty3Levelt = Number(this.champAbilty3Level) + 1;
      localStorage.setItem('Champion1Abilty3Level',this.champAbilty3Levelt.toString());
    }
  }
  levelUpAbilty4(){
    this.champAbilty4Level = localStorage.getItem('Champion1Abilty4Level');
    if(Number(this.champAbilty4Level) <3){
      this.service.updatePlayer1Abilty4LevelUp();
      this.champAbilty4Levelt = Number(this.champAbilty4Level) + 1;
      localStorage.setItem('Champion1Abilty4Level',this.champAbilty4Levelt.toString());
    }
  }

  levelDownAbilty1(){
    this.champAbilty1Level = localStorage.getItem('Champion1Abilty1Level');
    if(Number(this.champAbilty1Level) >0){
      this.service.updatePlayer1Abilty1LevelDown();
      this.champAbilty1Levelt = Number(this.champAbilty1Level) - 1;
      localStorage.setItem('Champion1Abilty1Level',this.champAbilty1Levelt.toString());
    }
  }
  levelDownAbilty2(){
    this.champAbilty2Level = localStorage.getItem('Champion1Abilty2Level');
    if(Number(this.champAbilty2Level) >0){
      this.service.updatePlayer1Abilty2LevelDown();
      this.champAbilty2Levelt = Number(this.champAbilty2Level) - 1;
      localStorage.setItem('Champion1Abilty2Level',this.champAbilty2Levelt.toString());
    }
  }
  levelDownAbilty3(){
    this.champAbilty3Level = localStorage.getItem('Champion1Abilty3Level');
    if(Number(this.champAbilty3Level) >0){
      this.service.updatePlayer1Abilty3LevelDown();
      this.champAbilty3Levelt = Number(this.champAbilty3Level) - 1;
      localStorage.setItem('Champion1Abilty3Level',this.champAbilty3Levelt.toString());
    }
  }
  levelDownAbilty4(){
    this.champAbilty4Level = localStorage.getItem('Champion1Abilty4Level');
    if(Number(this.champAbilty4Level) >0){
      this.service.updatePlayer1Abilty4LevelDown();
      this.champAbilty4Levelt = Number(this.champAbilty4Level) - 1;
      localStorage.setItem('Champion1Abilty4Level',this.champAbilty4Levelt.toString());
    }
  }

  Player1Item1Set(){
    this.champ1Item1 = localStorage.getItem('Champion1Item1');
    if(this.champ1Item1 == "none"){
      this.player1.item1 = "BFSword";
      this.service.updatePlayer1Item1(this.player1);
      localStorage.setItem('Champion1Item1',this.player1.item1);
    }
  }
  Player1Item2Set(){
    this.champ1Item2 = localStorage.getItem('Champion1Item2');
    if(this.champ1Item2 == "none"){
      this.player1.item2 = "BFSword";
      this.service.updatePlayer1Item2(this.player1);
      localStorage.setItem('Champion1Item2',this.player1.item2);
    }
  }
  Player1Item3Set(){
    this.champ1Item3 = localStorage.getItem('Champion1Item3');
    if(this.champ1Item3 == "none"){
      this.player1.item3 = "BFSword";
      this.service.updatePlayer1Item1(this.player1);
      localStorage.setItem('Champion1Item3',this.player1.item3);
    }
  }
  Player1Item4Set(){
    this.champ1Item4 = localStorage.getItem('Champion1Item4');
    if(this.champ1Item4 == "none"){
      this.player1.item4 = "BFSword";
      this.service.updatePlayer1Item4(this.player1);
      localStorage.setItem('Champion1Item4',this.player1.item4);
    }
  }
  Player1Item5Set(){
    this.champ1Item5 = localStorage.getItem('Champion1Item5');
    if(this.champ1Item5 == "none"){
      this.player1.item5 = "BFSword";
      this.service.updatePlayer1Item5(this.player1);
      localStorage.setItem('Champion1Item5',this.player1.item5);
    }
  }
  Player1Item6Set(){
    this.champ1Item6 = localStorage.getItem('Champion1Item6');
    if(this.champ1Item6 == "none"){
      this.player1.item6 = "BFSword";
      this.service.updatePlayer1Item6(this.player1);
      localStorage.setItem('Champion1Item6',this.player1.item6);
    }
  }


  Player1Item1Remove(){
    this.champ1Item1 = localStorage.getItem('Champion1Item1');
    if(this.champ1Item1 == "BFSword"){
      this.player1.item1 = "none";
      this.service.updatePlayer1Item1(this.player1);
      localStorage.setItem('Champion1Item1',this.player1.item1);
    }
  }
  Player1Item2Remove(){
    this.champ1Item2 = localStorage.getItem('Champion1Item2');
    if(this.champ1Item2 == "BFSword"){
      this.player1.item2 = "none";
      this.service.updatePlayer1Item2(this.player1);
      localStorage.setItem('Champion1Item2',this.player1.item2);
    }
  }
  Player1Item3Remove(){
    this.champ1Item3 = localStorage.getItem('Champion1Item3');
    if(this.champ1Item3 == "BFSword"){
      this.player1.item3 = "none";
      this.service.updatePlayer1Item1(this.player1);
      localStorage.setItem('Champion1Item3',this.player1.item3);
    }
  }
  Player1Item4Remove(){
    this.champ1Item4 = localStorage.getItem('Champion1Item4');
    if(this.champ1Item4 == "BFSword"){
      this.player1.item4 = "none";
      this.service.updatePlayer1Item4(this.player1);
      localStorage.setItem('Champion1Item4',this.player1.item4);
    }
  }
  Player1Item5Remove(){
    this.champ1Item5 = localStorage.getItem('Champion1Item5');
    if(this.champ1Item5 == "BFSword"){
      this.player1.item5 = "none";
      this.service.updatePlayer1Item5(this.player1);
      localStorage.setItem('Champion1Item5',this.player1.item5);
    }
  }
  Player1Item6Remove(){
    this.champ1Item6 = localStorage.getItem('Champion1Item6');
    if(this.champ1Item6 == "BFSword"){
      this.player1.item6 = "none";
      this.service.updatePlayer1Item6(this.player1);
      localStorage.setItem('Champion1Item6',this.player1.item6);
    }
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

  Player2Item1Set(){
    this.champ2Item1 = localStorage.getItem('Champion2Item1');
    if(this.champ2Item1 == "none"){
      this.player2.item1 = "BFSword";
      this.service.updatePlayer2Item1(this.player2);
      localStorage.setItem('Champion2Item1',this.player2.item1);
    }
  }
  Player2Item2Set(){
    this.champ2Item2 = localStorage.getItem('Champion2Item2');
    if(this.champ2Item2 == "none"){
      this.player2.item2 = "BFSword";
      this.service.updatePlayer2Item2(this.player2);
      localStorage.setItem('Champion2Item2',this.player2.item2);
    }
  }
  Player2Item3Set(){
    this.champ2Item3 = localStorage.getItem('Champion2Item3');
    if(this.champ2Item3 == "none"){
      this.player2.item3 = "BFSword";
      this.service.updatePlayer2Item1(this.player2);
      localStorage.setItem('Champion2Item3',this.player2.item3);
    }
  }
  Player2Item4Set(){
    this.champ2Item4 = localStorage.getItem('Champion2Item4');
    if(this.champ2Item4 == "none"){
      this.player2.item4 = "BFSword";
      this.service.updatePlayer2Item4(this.player2);
      localStorage.setItem('Champion2Item4',this.player2.item4);
    }
  }
  Player2Item5Set(){
    this.champ2Item5 = localStorage.getItem('Champion2Item5');
    if(this.champ2Item5 == "none"){
      this.player2.item5 = "BFSword";
      this.service.updatePlayer2Item5(this.player2);
      localStorage.setItem('Champion2Item5',this.player2.item5);
    }
  }
  Player2Item6Set(){
    this.champ2Item6 = localStorage.getItem('Champion2Item6');
    if(this.champ2Item6 == "none"){
      this.player2.item6 = "BFSword";
      this.service.updatePlayer2Item6(this.player2);
      localStorage.setItem('Champion2Item6',this.player2.item6);
    }
  }


  Player2Item1Remove(){
    this.champ2Item1 = localStorage.getItem('Champion2Item1');
    if(this.champ2Item1 == "BFSword"){
      this.player2.item1 = "none";
      this.service.updatePlayer2Item1(this.player2);
      localStorage.setItem('Champion2Item1',this.player2.item1);
    }
  }
  Player2Item2Remove(){
    this.champ2Item2 = localStorage.getItem('Champion2Item2');
    if(this.champ2Item2 == "BFSword"){
      this.player2.item2 = "none";
      this.service.updatePlayer2Item2(this.player2);
      localStorage.setItem('Champion2Item2',this.player2.item2);
    }
  }
  Player2Item3Remove(){
    this.champ2Item3 = localStorage.getItem('Champion2Item3');
    if(this.champ2Item3 == "BFSword"){
      this.player2.item3 = "none";
      this.service.updatePlayer2Item1(this.player2);
      localStorage.setItem('Champion2Item3',this.player2.item3);
    }
  }
  Player2Item4Remove(){
    this.champ1Item4 = localStorage.getItem('Champion2Item4');
    if(this.champ2Item4 == "BFSword"){
      this.player2.item4 = "none";
      this.service.updatePlayer2Item4(this.player2);
      localStorage.setItem('Champion2Item4',this.player2.item4);
    }
  }
  Player2Item5Remove(){
    this.champ2Item5 = localStorage.getItem('Champion2Item5');
    if(this.champ2Item5 == "BFSword"){
      this.player2.item5 = "none";
      this.service.updatePlayer2Item5(this.player2);
      localStorage.setItem('Champion2Item5',this.player2.item5);
    }
  }
  Player2Item6Remove(){
    this.champ2Item6 = localStorage.getItem('Champion2Item6');
    if(this.champ2Item6 == "BFSword"){
      this.player2.item6 = "none";
      this.service.updatePlayer2Item6(this.player2);
      localStorage.setItem('Champion2Item6',this.player2.item6);
    }
  }
}
