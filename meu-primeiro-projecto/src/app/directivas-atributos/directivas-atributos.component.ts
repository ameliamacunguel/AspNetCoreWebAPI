import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directivas-atributos',
  templateUrl: './directivas-atributos.component.html',
  styleUrls: ['./directivas-atributos.component.scss']
})
export class DirectivasAtributosComponent implements OnInit {

  public valor:boolean = true;
  public heightPx: string="20px";
  public backgroundColor: string= "red";

  public nome: string = "";
  public list:Array<{nome:string}> = [];

  constructor(){}
  
  ngOnInit(): void {
   setInterval(()=>{
    if(this.valor)
    {
      this.valor= false;
    }else{
      this.valor=true;
    }

    if (this.heightPx=="20px") {
      this.heightPx= "50px";
    }else{
      this.heightPx= "20px";
    }
   },2000);   
  }
}
