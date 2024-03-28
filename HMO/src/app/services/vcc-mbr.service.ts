import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { VaccMbr } from '../classes/VaccMbr';
import { Observable } from 'rxjs';
import { Vaccination } from '../classes/Vaccination';

@Injectable({
  providedIn: 'root'
})
export class VccMbrService {
  listVaccMem: Array<VaccMbr> = new Array<VaccMbr>()

  constructor(public http: HttpClient, public r: Router) { }
  
  GetAllMemVacc(id:number):Observable<Array<VaccMbr>>{
    debugger
    return this.http.get<Array<VaccMbr>>('https://localhost:7202/api/Vaccmem/GetAllVaccForMem/'+id)
  }
  GetAllVacc():Observable<Array<Vaccination>>{
    debugger
    return this.http.get<Array<Vaccination>>('https://localhost:7202/api/Vacc/GetAllVacc')
  }
  Addvacc(vacc:VaccMbr):Observable<number> {
    debugger
    return this.http.post<number>('https://localhost:7202/api/Vaccmem/AddVaccMem',vacc)
   }
}
