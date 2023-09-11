import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import { TitleComponent } from './title/title.component';
import { DataBidingComponent } from './data-biding/data-biding.component';
import { DirectivasEstruturaisComponent } from './directivas-estruturais/directivas-estruturais.component';
import { DirectivasAtributosComponent } from './directivas-atributos/directivas-atributos.component';
import { SharedModule } from './shared/shared.module';



@NgModule({

  declarations: [
    AppComponent,
    TitleComponent,
    DataBidingComponent,
    DirectivasEstruturaisComponent,
    DirectivasAtributosComponent,
    
  ],

  imports: [
    CommonModule,
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    SharedModule

  ],

  providers: [],
  bootstrap:[AppComponent]

})
export class AppModule { }
