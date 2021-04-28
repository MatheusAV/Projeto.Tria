import { HttpClient } from '@angular/common/http';
import { ConvertActionBindingResult } from '@angular/compiler/src/compiler_util/expression_converter';
import { Parser } from '@angular/compiler/src/ml_parser/parser';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { Cliente } from '../Model/Cliente';

@Component({
  selector: 'app-EditarCliente',
  templateUrl: './EditarCliente.component.html',
  styleUrls: ['./EditarCliente.component.css']
})
export class EditarClienteComponent implements OnInit {
id: string | null | undefined;
header: string | undefined| null;

cliente: Cliente = {
  idCliente: 0,
  nomeDaEmpresa: '',
  nomeDoCliente: '',
  tel: '',
  e_mail: '',
  idProduto: 0,
  conteudo: '',
  dtAlteracao: new Date(),
  dtAtendimento: new Date(),
  hrAtendimento: '',
  produto: null,
}


  constructor(private route: ActivatedRoute, private rota: Router, private http: HttpClient) { }

  ngOnInit(): void{
   this.id = this.route.snapshot.paramMap.get('id');
   this.header = this.id === "0" ? 'Novo Cliente' : 'Editar Cliente';

   if(this.id !== '0'){
    this.http.get<Cliente>(environment.localUrl + 'api/Cliente/ConsultarCliente?idCliente=' + this.id).subscribe(retorno => {
     this.cliente = retorno;
    });


   }
  }


  salvar(ngForm: NgForm): void{
    let cliente: Cliente = {
       idCliente: ngForm.value.idCliente,
       nomeDaEmpresa: ngForm.value.nmEmpresa,
      nomeDoCliente: ngForm.value.nmCliente,
      tel: ngForm.value.tel,
      e_mail: ngForm.value.email,
      idProduto: +ngForm.value.produto,
      conteudo: ngForm.value.conteudo,
      dtAlteracao: new Date(),
      dtAtendimento: new Date(),
      hrAtendimento: "",
      produto: null,
    }

    this.http.post(environment.localUrl + 'api/Cliente/Adicionar', cliente).subscribe(x => {
      this.rota.navigateByUrl('');
    });

  }

  editar(ngForm: NgForm): void{
    let cliente: Cliente = {
       idCliente: ngForm.value.idCliente,
       nomeDaEmpresa: ngForm.value.nmEmpresa,
      nomeDoCliente: ngForm.value.nmCliente,
      tel: ngForm.value.tel,
      e_mail: ngForm.value.email,
      idProduto: +ngForm.value.produto,
      conteudo: ngForm.value.conteudo,
      dtAlteracao: new Date(),
      dtAtendimento: new Date(),
      hrAtendimento: "",
      produto: null,
    }

    this.http.post(environment.localUrl + 'api/Cliente/Editar', cliente).subscribe(x => {
      this.rota.navigateByUrl('');
    });

  }
}
