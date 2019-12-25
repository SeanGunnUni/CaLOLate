import { Component, OnInit , Injectable} from '@angular/core';
import { ChampionsService } from '../champions.service';

@Component({
  selector: 'app-champions',
  templateUrl: './champions.component.html',
  styleUrls: ['./champions.component.css']

  
})

@Injectable()
export class ChampionsComponent implements OnInit {

  constructor(private service:ChampionsService) { }
  title = "the title";
  Champ = "";
  ngOnInit() {
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }
  click(){
    this.title += " button was clicked";
  }
  click1(){
    this.Champ = "Ashe";
  }
  click2(){
    this.Champ = "Garen";
  }
  click3(){
    this.Champ = "Amumu";
  }
  click4(){
    this.Champ = "Annie";
  }
  click5(){
    this.Champ = "Zilean";
  }
}
