import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ChampionsComponent } from './championsFromHTML/champions.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';

//services
import {ChampionsService} from './champions.service';
import { AppRouterModule } from './app-router.module';
import { HttpClientModule } from '@angular/common/http';

//material design
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './materialMods/material.module';
import { ModalComponent } from './HELP POPUPS/help.component';
@NgModule({
  declarations: [
    AppComponent,
    ChampionsComponent,
    
    FooterComponent,
    HeaderComponent,
    ModalComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRouterModule,
    //material design
    BrowserAnimationsModule,
    MaterialModule 
  ],
  providers: [ChampionsService],
  bootstrap: [AppComponent],
  entryComponents: [ModalComponent]
})
export class AppModule { }