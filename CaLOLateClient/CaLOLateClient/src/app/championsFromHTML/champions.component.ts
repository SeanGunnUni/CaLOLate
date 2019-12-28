import { Component, OnInit , Injectable, Input} from '@angular/core';
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
    console.log('Started app');
  }
  clickAshe(){
    this.Champ = "Ashe";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }
  clickAnnie(){
    this.Champ = "Annie";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }
  clickGaren(){
    this.Champ = "Garen";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }
  clickZilean(){
    this.Champ = "Zilean";
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }
}

