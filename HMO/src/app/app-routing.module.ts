import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoreDetailsComponent } from './component/more-details/more-details.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { AllMembersComponent } from './component/all-members/all-members.component';


const routes: Routes = [
  {path:'', component:AllMembersComponent},
  {path:'add-member', component:SignInComponent},
  {path:'all-member', component:AllMembersComponent},
  {path:'moreDetails', component:MoreDetailsComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

