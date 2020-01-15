import {RouterModule, Routes} from '@angular/router';

//component
import {ChampionsComponent} from './championsFromHTML/champions.component';
import {RegisterComponent} from './register/register.component';
import {BattlerTop} from './BattlerAPI/BattlerAPITop.component';
import {BattlerBot} from './BattlerAPI/BattlerAPIBot.component';
import {BattlerCal} from './BattlerAPI/BattlerAPICalculator.component';
import {LoginComponet} from './login/login.component'
import { NgModule } from '@angular/core';

//routes
const routes:Routes = [
    {path:'',component:ChampionsComponent},
    {path:'champions', component:ChampionsComponent},
    {path:'Register', component:RegisterComponent},
    {path:'BattlerTop',component:BattlerTop},
    {path:'BattlerBot',component:BattlerBot},
    {path:'BattlerCal',component:BattlerCal},
    {path:'Login', component:LoginComponet},
]

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRouterModule{}