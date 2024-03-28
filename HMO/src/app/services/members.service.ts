
import { Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { Members } from '../classes/Members';

@Injectable({
  providedIn: 'root'
})
export class MembersService {
  AddOrEdit:boolean=false
  m: Members = new Members
  listMembers: Array<Members> = new Array<Members>()
  constructor(public http: HttpClient, public r: Router) { }
  Details(m: Members) {
    debugger 
    this.m = m;
    this.r.navigate(['/moreDetails'])
  }
  GetAllMembers(): Observable<Array<Members>> {
    return this.http.get<Array<Members>>('https://localhost:7202/api/Member/GetAllMembers')
  }
  AddMember():Observable<number> {
    debugger
    return this.http.post<number>('https://localhost:7202/api/Member/AddMember',this.m)
   }
   DeleteMember(id: number): Observable<boolean> {
    debugger
       return this.http.delete<boolean>('https://localhost:7202/api/Member/DeleteMember/'+ id)
       }
  }