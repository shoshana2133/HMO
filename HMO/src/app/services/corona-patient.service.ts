import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { CoronaPatient } from '../classes/CoronaPatient';


@Injectable({
  providedIn: 'root'
})
export class CoronaPatientService {

  constructor(public http: HttpClient) { }
  AddCoronaPatient(cp:CoronaPatient):Observable<number> {
    return this.http.post<number>('https://localhost:7202/api/CoronaPatient/AddCoronaPatient',cp)
   }

}
