import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {

  constructor(private http: HttpClient) { }

  GetTotalCandidato() {
    return new Promise((resolve, reject) => {
      return this.http
        .get(
          `${environment.candidato}`
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
}
