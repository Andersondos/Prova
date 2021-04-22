import { Component, OnInit } from '@angular/core';
import { candidato } from '../Models/candidato';

import { candidatoService } from '../candidato/service/candidato.service'
@Component({
  selector: 'app-candidato',
  templateUrl: './candidato.component.html',
  styleUrls: ['./candidato.component.css']
})
export class CandidatoComponent implements OnInit {
  cadidatoList : any = []

  candidato : candidato = {
    nome:  null ,
    endereco:  null,
    telefone:  null,
    email: null,
    tecnologia:  null,
    cargo: null,
    experiencia: null,
    observacao:  null
  }
  constructor() { }

  async ngOnInit() {
    this.cadidatoList = await this.candidatoService.GetTotalCandidato()
  }

}
