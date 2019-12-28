import {RouterModule, Routes} from '@angular/router';

//component
import {ChampionsComponent} from './championsFromHTML/champions.component';
import { NgModule } from '@angular/core';

//routes
const routes:Routes = [
    {path:'',component:ChampionsComponent},
    {path:'champions', component:ChampionsComponent}
]

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRouterModule{}