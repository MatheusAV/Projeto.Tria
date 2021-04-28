import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { Cliente } from '../Model/Cliente';


@Component({
  selector: 'app-Cliente',
  templateUrl: './Cliente.component.html',
  styleUrls: ['./Cliente.component.css']
})
export class ClienteComponent implements OnInit {

  clientes: Cliente[] = [];

  constructor(public http: HttpClient, private rota: Router) { }



  ngOnInit(): void {
    this.http.get<Cliente[]>(environment.localUrl + 'api/Cliente/listar').subscribe(retorno => {
      this.clientes = retorno;
    });
  }

  editar(id: number): void {
    this.http.get<Cliente>(environment.localUrl + 'api/Cliente/ConsultarCliente?idCliente=' + id.toString()).subscribe(retorno => {
      console.log(retorno);
    });

  }

     deletar(id: number): void {
      this.http.get(environment.localUrl + 'api/Cliente/Deletar?idCliente=' + id.toString()).subscribe(retorno => {
        this.ngOnInit();
      });
}


}
