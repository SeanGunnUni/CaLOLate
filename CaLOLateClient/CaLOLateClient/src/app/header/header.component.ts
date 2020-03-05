import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';
import {ChampionsService} from '../champions.service'
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private auth:AuthService,private service:ChampionsService) { }

  ngOnInit() {
  }
  cleanLocalStorage() {
    for(const key in localStorage) {
      if(key == "userName" || key == "tokenValue")
         console.log("Resetting local storage");
      else
        delete localStorage[key];
    }
  }
}
