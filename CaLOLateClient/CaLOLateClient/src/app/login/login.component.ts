import { Component, OnInit, ComponentFactoryResolver } from '@angular/core';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

  loginData = {
    username:'',
    password:''
  }

  constructor(private service:AuthService, private router:Router) { }

  login(){
    console.log(this.loginData);
    this.service.login(this.loginData).subscribe((data:any)=>{
      console.log(data);
      localStorage.setItem('userName',data.userName);
      localStorage.setItem('tokenValue',data.tokenValue);
      this.router.navigate(['/champion']);
    }
    ,(error)=>alert(error.error.Message));
  }
}
