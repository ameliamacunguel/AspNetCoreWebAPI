import { from } from "rxjs";
import { Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-root',
  template:`
    <app-directivas-atributos></app-directivas-atributos>
    <router-outlet></router-outlet>
 `
 })

export class AppComponent implements OnInit {

  constructor(){}

  ngOnInit(): void {}

}
