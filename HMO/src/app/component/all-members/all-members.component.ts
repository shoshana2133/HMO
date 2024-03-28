import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Members } from 'src/app/classes/Members';
import { MembersService } from 'src/app/services/members.service';
import { VccMbrService } from 'src/app/services/vcc-mbr.service';


@Component({
  selector: 'app-all-members',
  templateUrl: './all-members.component.html',
  styleUrls: ['./all-members.component.css']
})

export class AllMembersComponent implements OnInit {
  m:Members=new Members
   constructor(public ms: MembersService,public r:Router, public vm:VccMbrService) { }
   listMembers: Array<Members> = new Array<Members>()
   ngOnInit(): void {
    debugger
     this.ms.GetAllMembers().subscribe(
       succ=>{this.listMembers=succ;
        this.ms.listMembers=this.listMembers
       console.table(this.listMembers)
     },
       err=>{alert(err.massage)}
     )
     
     
   }

 }
