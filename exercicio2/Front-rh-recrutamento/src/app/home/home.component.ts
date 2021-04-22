import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  
  ngOnInit() {
  }

  vaga() {
    console.log("rota Vaga")
  }
  candidato() {
    console.log("rota cadidato")
  }
}
