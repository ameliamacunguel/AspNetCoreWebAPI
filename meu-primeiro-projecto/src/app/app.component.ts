import { from } from "rxjs";
import { Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-root',
  template:`
  <ng-template [ngIf]="getDados">
    <h1>{{getDados.nome}}</h1>
    <h2>{{getDados.idade}}</h2>
  </ng-template>
  
    <app-output (enviarDados)="setDados($event)" ></app-output>
    
    <router-outlet></router-outlet>

    <!--
      <app-input [contador]="addValue"></app-input>
    <br>
    <button (click)="add()">Add</button>

     <app-new-component></app-new-component>
   
     <router-outlet></router-outlet>
      <h1>Aulas de Directivas de Atributo</h1>
      <h3>Fim da Aula</h3>
    </app-directivas-atributos>

    <app-directivas-atributos>
    <router-outlet></router-outlet>
      <h1>Dener Troquatte</h1>
      <h3>Nay Torre</h3>
    </app-directivas-atributos>
  -->
 `
 })

export class AppComponent implements OnInit {

public destruir: boolean = true;
public addValue: number = 0;

public getDados:{nome:string, idade: number} | undefined;

constructor(){}

  ngOnInit(): void {}

  public add(){
    this.addValue +=1;
  }
  public destruirComponent(){
    this.destruir = false;
  }

  public setDados(event:{nome: string, idade: number}){
    this.getDados = event;
  }
}
