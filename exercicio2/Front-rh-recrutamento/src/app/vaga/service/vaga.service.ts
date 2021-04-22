import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VagaService {

  constructor(private http: HttpClient) { }

  GetTotalVagas(){
    return new Promise((resolve, reject) => {
      return this.http
        .get(
          `${environment.vaga}`
        )
        .subscribe(
          res => {
            resolve(res);
          },
          err => {
            console.log(err);
            reject(err);
          }
        );
    });
  }

  RegistrarVaga(vaga)
  {
    return new Promise((resolve, reject) => {
      return this.http
        .post<any>(`${environment.vaga}`, vaga )
        .subscribe(
          res => {
            resolve(res);
          },
          err => {
            console.log(err);
            reject(err);
          }
        );
      }); 
  }
}
