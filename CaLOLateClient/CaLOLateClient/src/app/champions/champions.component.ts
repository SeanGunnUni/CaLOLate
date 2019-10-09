import { Component, OnInit } from '@angular/core';
import { ChampionsService } from '../champions.service';

@Component({
  selector: 'app-champions',
  templateUrl: './champions.component.html',
  styleUrls: ['./champions.component.css']
})
export class ChampionsComponent implements OnInit {

  constructor(private service:ChampionsService) { }

  ngOnInit() {
    this.service.getAll().subscribe((data) => { 
      console.log('Result - ', data);
    })
  }

}
