import { Component, OnInit } from '@angular/core';
import { vaga } from '../Models/vaga';

import { VagaService } from './service/vaga.service';

@Component({
  selector: 'app-vaga',
  templateUrl: './vaga.component.html',
  styleUrls: ['./vaga.component.css']
})
export class VagaComponent implements OnInit {

  vagaList :any = []

  vaga : vaga = {
    empresa:  null ,
    endereco:  null,
    telefone:  null,
    email: null,
    tecnologia:  null,
    responsavel: null,
    observacao:  null
  }
  
  constructor(
    private vagaService: VagaService
    ) { }

  async ngOnInit() {
    this.vagaList = await this.vagaService.GetTotalVagas()
  }

}
