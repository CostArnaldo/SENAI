import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  constructor(private loginService: LoginService, private router: Router) { }

  ngOnInit(): void {const listaPalavras: string[] = ["select ", "from ", "drop ", "or ", "having ", "group ", "by ", "insert ", "exec ", "\"", "\ '", "--", "#", "*", ";"]
    listaPalavras.forEach(palavra => {
    if(this.userModel.email?.toLowerCase().includes(palavra)) {
      this.mensagem = "Dados inválidos"
      return;
    }
  });
  }

  userModel = new User();
  mensagem = "";

  receberDados() {
    
    
    this.loginService.login(this.userModel).subscribe((response) => {
      console.log("login realizado")
      localStorage.setItem("nomeUsuario", response.body.user.nome)
      this.router.navigateByUrl("/")
    }, (erro) => {
      console.log(erro.error)
    })
  }

}
