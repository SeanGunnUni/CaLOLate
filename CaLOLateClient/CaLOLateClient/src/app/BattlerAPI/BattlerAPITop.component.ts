import { Component, OnInit , Injectable, Input} from '@angular/core';
import { ChampionsService } from '../champions.service';

@Component({
    selector: 'app-champions',
    templateUrl: './BattlerAPITop.component.html',
    styleUrls: ['./BattlerAPITop.component.css']
  
})

@Injectable()
export class BattlerAPITopComponent implements OnInit {

    constructor(private service:ChampionsService,) { 

    }

    public listItemsChampLevel: Array<string> = ["1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12","13", "14", "15", "16", "17", "18"];
    public listItemsBattlerLength: Array<string> = ["10 seconds", "20 seconds", "30 seconds", "40 seconds"];
    ngOnInit() {
        console.log('Started app');
    }
}