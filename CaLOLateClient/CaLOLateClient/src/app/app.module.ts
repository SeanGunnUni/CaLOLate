import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ChampionsComponent } from './championsFromHTML/champions.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { BattlerComponent } from './BattlerAPI/battler/battler.component';

//services
import {ChampionsService} from './champions.service';
import { AppRouterModule } from './app-router.module';
import { HttpClientModule } from '@angular/common/http';
import {AuthService} from './auth.service';

//material design
import {MatCardModule} from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './materialMods/material.module';
import {MatToolbarModule} from '@angular/material/toolbar';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { InputsModule } from '@progress/kendo-angular-inputs';
import { PopupModule } from '@progress/kendo-angular-popup';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';


@NgModule({
  declarations: [
    AppComponent,
    ChampionsComponent,
    FooterComponent,
    HeaderComponent,
    LoginComponent,
    RegisterComponent,
    BattlerComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRouterModule,
    //material design
    BrowserAnimationsModule,
    MaterialModule,
    MatToolbarModule,
    FormsModule,
    ReactiveFormsModule,
    MatCardModule,
    InputsModule,
    PopupModule,
    DropDownsModule
  ],
  providers: [ChampionsService, AuthService],
  bootstrap: [AppComponent],
  entryComponents: []
})
export class AppModule { }