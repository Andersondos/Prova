import { ModuleWithProviders, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CadastrarVagaComponent } from './cadastrar-vaga/cadastrar-vaga.component';
import { CadastroCadidatoComponent } from './cadastro-cadidato/cadastro-cadidato.component';
import { CandidatoComponent } from './candidato/candidato.component';
import { HomeComponent } from './home/home.component';
import { VagaComponent } from './vaga/vaga.component';


const APP_Routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'vaga', component: VagaComponent },
  { path: 'candidato', component: CandidatoComponent },
  { path: 'cadastrarVaga', component: CadastrarVagaComponent },
  { path: 'cadastrarCadidato', component: CadastroCadidatoComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(APP_Routes);