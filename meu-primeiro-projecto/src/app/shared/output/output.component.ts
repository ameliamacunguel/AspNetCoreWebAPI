import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-output',
  templateUrl: './output.component.html',
  styleUrls: ['./output.component.scss']
})
export class OutputComponent implements OnInit {

  @Output() public enviarDados = new EventEmitter();
  public list: Array<{nome: String, idade: Number}> =[
  {nome: "Dener Troquatte", idade:29},
  {nome: "Nay", idade:31},
  {nome: "Jose", idade:58}
  ]
  constructor(){}

  ngOnInit(): void {}
  
  public getDados (event: number){
    this.enviarDados.emit(this.list[event]);
   
  }
}
