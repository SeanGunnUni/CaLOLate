import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ChampionsComponent } from './champions/champions.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';

//services
import {ChampionsService} from './champions.service';
import { AppRouterModule } from './app-router.module';
import { HttpClientModule } from '@angular/common/http';

//material design
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    ChampionsComponent,
    FooterComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRouterModule,
    //material design
    BrowserAnimationsModule
  ],
  providers: [ChampionsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
