import {RouterModule, Routes} from '@angular/router';

//component
import {ChampionsComponent} from './championsFromHTML/champions.component';
import {RegisterComponent} from './register/register.component';
import {BattlerComponent} from './BattlerAPI/battler/battler.component';
import {LoginComponent} from './login/login.component'
import { NgModule } from '@angular/core';

//routes
const routes:Routes = [
    {path:'',component:ChampionsComponent},
    {path:'champions', component:ChampionsComponent},
    {path:'Register', component:RegisterComponent},
    {path:'Battler', component:BattlerComponent},
    {path:'Login', component:LoginComponent},
]

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRouterModule{}