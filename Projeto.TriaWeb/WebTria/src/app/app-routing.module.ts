import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClienteComponent } from './Cliente/Cliente.component';
import { EditarClienteComponent } from './EditarCliente/EditarCliente.component';

const routes: Routes = [
  {
    path: "",
    component: ClienteComponent
  },
  {
    path: "Cliente/add/:id",
    component: EditarClienteComponent
  },
  {
    path: "Cliente/edit/:id",
    component: EditarClienteComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
