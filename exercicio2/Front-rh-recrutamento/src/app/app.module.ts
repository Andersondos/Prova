import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { VagaComponent } from './vaga/vaga.component';
import { CandidatoComponent } from './candidato/candidato.component';
import { routing } from './app-routing.module';
import { CadastrarVagaComponent } from './cadastrar-vaga/cadastrar-vaga.component';
import { CadastroCadidatoComponent } from './cadastro-cadidato/cadastro-cadidato.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    VagaComponent,
    CandidatoComponent,
    CadastrarVagaComponent,
    CadastroCadidatoComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    routing
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
