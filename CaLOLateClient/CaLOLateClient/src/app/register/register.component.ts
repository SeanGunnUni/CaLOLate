import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  registerForm: FormGroup;

  constructor(private fb: FormBuilder, private service: AuthService) {

    this.registerForm = fb.group({
      userName: ['', Validators.required],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required]
    
   },{validators: matchingField('password','confirmPassword')})

  }
  onSubmit(){
    delete this.registerForm.value.confirmPassword;
    this.service.register(this.registerForm.value).subscribe((data:any)=>{
      console.log(data);
      localStorage.setItem('userName',data.userName);
      localStorage.setItem('tokenValue',data.tokenValue);
    })
  }
}
function matchingField(field1,field2){
    return (form: { controls: { [x: string]: { value: any; }; }; }) =>{
      if(form.controls[field1].value !== form.controls[field2].value)
      return {matchingFields: true}
    }
  }