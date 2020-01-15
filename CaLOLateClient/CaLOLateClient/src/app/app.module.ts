import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ChampionsComponent } from './championsFromHTML/champions.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { APITop } from './BattlerAPI/BattlerAPITop.component';
import { APIBot } from './BattlerAPI/BattlerAPIBot.component';
import { APICal } from './BattlerAPI/BattlerAPICalculator.component';

//services
import {ChampionsService} from './champions.service';
import { AppRouterModule } from './app-router.module';
import { HttpClientModule } from '@angular/common/http';
import {AuthService} from './auth.service';

//material design
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './materialMods/material.module';
import { ModalComponent } from './HELP POPUPS/help.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import { LoginComponent } from './login/login.component';

import { FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ChampionsComponent,
    APIBot,
    APICal,
    APITop,
    FooterComponent,
    HeaderComponent,
    ModalComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRouterModule,
    //material design
    BrowserAnimationsModule,
    MaterialModule,
    MatToolbarModule,
    FormsModule
  ],
  providers: [ChampionsService, AuthService],
  bootstrap: [AppComponent],
  entryComponents: [ModalComponent]
})
export class AppModule { }