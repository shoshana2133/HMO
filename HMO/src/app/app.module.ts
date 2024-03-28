import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './component/nav/nav.component';
import { FormsModule } from '@angular/forms';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { MoreDetailsComponent } from './component/more-details/more-details.component';
import { AllMembersComponent } from './component/all-members/all-members.component';


@NgModule({
  declarations: [
    AppComponent,
 NavComponent,
    SignInComponent,
    MoreDetailsComponent,
    AllMembersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
