import { Component, OnInit } from '@angular/core';
import { ConexaoService } from '../../services/conexao.service';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit {

  items: any;
  editaItem: any = {
    name: ''
  }
  constructor(private conexao: ConexaoService) { 
    this.conexao.listaItem().subscribe(item =>{
      this.items = item;
      console.log(this.items)
    })
  }

  ngOnInit() {
  }
  excluir(item){
    this.conexao.excluirItem(item);
  }
  editar(item){
    this.editaItem = item;
  }
  addItemEditado(){
    this.conexao.editarItem(this.editaItem)
  }

}
