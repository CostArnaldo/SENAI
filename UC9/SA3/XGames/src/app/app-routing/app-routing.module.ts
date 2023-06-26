import { NgModule } from '@angular/core';
import {RouterModule, Routes} from '@angular/router'
import { HomeComponent } from '../views/home/home.component';
import { LoginComponent } from '../views/login/login.component';

const routes: Routes = [ 
{path: "", component: HomeComponent}, 
{path: "login", component: LoginComponent}, 
{path: "campeonato", component: LoginComponent}, 
{path: "resultado", component: LoginComponent},
{path: "notícia", component: LoginComponent}]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
