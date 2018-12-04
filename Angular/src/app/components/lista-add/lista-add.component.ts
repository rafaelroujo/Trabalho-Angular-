import { Component, OnInit } from '@angular/core';
import { ConexaoService } from '../../services/conexao.service';

@Component({
  selector: 'app-lista-add',
  templateUrl: './lista-add.component.html',
  styleUrls: ['./lista-add.component.css']
})
export class ListaAddComponent implements OnInit {

  item: any = {
    name:''
  }

  constructor(private servico: ConexaoService) { }

  ngOnInit() {
  }
  addItem(){
    this.servico.addItem(this.item);
    this.item.name ='';
  }

}
