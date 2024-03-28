import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MembersService } from 'src/app/services/members.service';
import { Members } from 'src/app/classes/Members';
import { Vaccination } from 'src/app/classes/Vaccination';
import { AbstractControl, FormArray, ValidatorFn } from '@angular/forms';
import { VccMbrService } from 'src/app/services/vcc-mbr.service';
import { VaccMbr } from 'src/app/classes/VaccMbr';
import { CoronaPatient } from 'src/app/classes/CoronaPatient';
import { CoronaPatientService } from 'src/app/services/corona-patient.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit{
  constructor(public ms: MembersService,public r:Router, public vm : VccMbrService,public cpt: CoronaPatientService) { }
  id:number=0
  count:number=0
  mem:Members=new Members()
  vaccmam:VaccMbr=new VaccMbr();
  isVacc:boolean=false;
  isKorona:boolean=false;
  isValid:boolean=true;
  vacc: Array<Vaccination> = new Array<Vaccination>()
  vaccMbrList: Array<VaccMbr> = new Array<VaccMbr>()
  cp:CoronaPatient= new CoronaPatient();

  ngOnInit(): void {
    this.ms.m=new Members
    this.vm.GetAllVacc().subscribe(
      succ=>{this.vacc=succ;
      console.table(this.vacc)
      this.ms.m.MbrPatient=false
      this.ms.m.MbrVaccinted=false
      
    },
      err=>{alert(err.massage)}
    )

  }
 
  AddMember(){
    this.ChakeMember()
  }
  boolKorona(){
    this.isKorona=!this.isKorona
    this.ms.m.MbrPatient=this.isKorona
  }
  boolisVacc(){
    this.isVacc=!this.isVacc
    this.ms.m.MbrVaccinted=this.isVacc
    this.vaccmam.VcCode=1
    this.vaccmam.VcManufacturer="פייזר"
  }

  IdValidator(idNumber:string) {
    debugger
   if(idNumber.length==9)
      // Check the control digit
     { const controlDigit = idNumber.substring(8, 9);
      const idWithoutControl = idNumber.substring(0, 8);
      let sum = 0;
      for (let i = 0; i < idWithoutControl.length; i++) {
        let num = parseInt(idWithoutControl[i], 10);
        num *= (i % 2) + 1;
        if (num > 9) {
          num -= 9;
        }
        sum += num;
      }
      const validControlDigit = ((sum + parseInt(controlDigit, 10)) % 10 === 0);
  
       
    this.isValid=validControlDigit;}
    else
    this.isValid=false;
    }
    addVacc(){
      console.log(this.vaccmam.VmDate)
      debugger
      if(this.count<4)
      {this.count++;
this.vaccMbrList.push(this.vaccmam)
this.vaccmam=new VaccMbr();
alert("החיסון נוסף בהצלחה")}
else alert("לא ניתן להזין יותר מ4 חיסונים")
    }
    find(n:string){
      this.vaccmam.VcManufacturer=n
this.vaccmam.VcCode=this.vacc.find(x=>x.VcManufacturer==n)?.VcCode
    }
    Getdate(d:string,n:string ){
      if(n=="tz")
      this.ms.m.MbrBirthDate=new Date(d);
    else  if(n=="vm")
      this.vaccmam.VmDate=new Date(d);
      else  if(n=="cpp")
      this.cp.CpDatePositive=new Date(d);
      else  if(n=="cpr")
      this.cp.CpDateRecovery=new Date(d);
}


  ChakeMember(){
        this.ms.AddMember().subscribe(

          succ=>{(this.id=succ)
            debugger
            if(this.id==-1)
            alert("לא ניתן להוסיף את החבר למערכת")
            else{
             if(this.ms.m.MbrPatient==true){
              this.cp.MbrCode=this.id
               this.cpt.AddCoronaPatient(this.cp).subscribe(
                s=>{
                  if(s==-1)
                  alert("יש בעיה בהוספת פרטי הקורונה למערכת")
                }
               )}
               if (this.ms.m.MbrVaccinted==true){
                debugger
               this.vaccMbrList.forEach(x=>x.MbrCode=this.id )
               for (let i = 0; i < this.vaccMbrList.length; i++) {
                debugger
                 this.vm.Addvacc(this.vaccMbrList[i]).subscribe(
                   suc=>{
                     if(suc==-1)
                     alert("יש בעיה בהוספת פרטי החיסון למערכת")
                    debugger},
                    er=>{
                      alert(er.massage)
                    }
                    )
                    }
               }
              
            alert("החבר נוסף בהצלחה")
            this.r.navigate(['/all-member'])
         }
          debugger
     
      },
          err=>{alert(err.massage)}
        )}
  
    }
  