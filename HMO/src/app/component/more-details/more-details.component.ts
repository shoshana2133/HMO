import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Members } from 'src/app/classes/Members';
import { MembersService } from 'src/app/services/members.service';

@Component({
  selector: 'app-more-details',
  templateUrl: './more-details.component.html',
  styleUrls: ['./more-details.component.css']
})

export class MoreDetailsComponent implements OnInit {
  places:number=0
  m:Members=new Members()
  constructor(public ms: MembersService,public r:Router) { }
  ngOnInit(): void {

  }
  deleteMem(){
     debugger
    this.ms.DeleteMember(this.ms.m.MbrCode!).subscribe(
     
      succ=>{
        if (succ==false)
        alert("לא ניתן למחוק חבר")
      else
      alert("חבר נמחק בהצלחה")
      }
      ,err=>{
        alert(err.massage)
      }
    )
    this.r.navigate(['/all-member'])
  }
}