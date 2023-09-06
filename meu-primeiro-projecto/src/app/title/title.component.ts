import { Component, Input, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent implements OnInit {

  //funcao @Input recebe por padrao "bem vindo"
  @Input() public title:string = "Bem vindo";

  constructor()  {}
  ngOnInit(): void {}

}
