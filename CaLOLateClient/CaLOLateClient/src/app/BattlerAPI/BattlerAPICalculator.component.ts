import { Component, OnInit , Injectable, Input} from '@angular/core';
import { ChampionsService } from '../champions.service';

@Component({
    selector: 'app-champions',
    templateUrl: './BattlerAPICalculator.component.html',
    styleUrls: ['./BattlerAPICalculator.component.css']
  
})

@Injectable()
export class BattlerAPICalculatorComponent implements OnInit {

    constructor(private service:ChampionsService,) { 

    }

   
    ngOnInit() {
        console.log('Started app');
    }
}