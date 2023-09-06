import { Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-directivas-estruturais',
  templateUrl: './directivas-estruturais.component.html',
  styleUrls: ['./directivas-estruturais.component.scss']
})
export class DirectivasEstruturaisComponent  implements OnInit {

public condition: boolean = true;
public conditionalClick:boolean = true;

public list: Array<{nome: string, idade: number}> = [
  {nome: "Dener Troquatte", idade: 29},
  {nome: "Jose", idade: 59},
  {nome: "Isabel", idade: 55}
];

public nome:string= 'dener';

constructor(){}

ngOnInit(): void {
  setInterval(()=>{
    if(this.condition){
    this.condition = false;
    }else{
    this.condition = true;
   }
  }, 2000)
}

public onClick(){
  if(this.conditionalClick){
    this.conditionalClick = false;
    }else{
    this.conditionalClick = true;
   }
}

public onClickAddList(){
  this.list.push({nome: "Nay", idade: 31});
}

public onClickEventList(event: number){
  this.list.splice(event, 1)
}

}
