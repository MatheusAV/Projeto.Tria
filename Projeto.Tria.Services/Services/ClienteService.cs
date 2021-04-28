using Projeto.Tria.Domain.Entities;
using Projeto.Tria.Infra.Ropositories.Interface;
using Projeto.Tria.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tria.Services.Services
{
     public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IList<Cliente>> Listar() 
        {
            var clientes = await _clienteRepository.GetAll();

            clientes.OrderBy(x => x.DtAtendimento);

            return clientes;
        }
        
        public async Task Editar(Cliente cliente)
        {
            cliente.DtAlteracao = DateTime.Now;
            _clienteRepository.AlterarAsync(cliente);
        }

        public async Task Adicionar (Cliente cliente)
        {

            cliente.DtAtendimento = DateTime.Now;
            cliente.HrAtendimento = DateTime.Now.ToString("HH:mm");
            _clienteRepository.Save (cliente);
        }

        public async Task Deletar (int idCliente)
        {
            var clientes = await _clienteRepository.GetAll();
            if (clientes.Count > 0)
            {
                var cliente = clientes.Where(x => x.IdCliente == idCliente).FirstOrDefault();
                _clienteRepository.Delete(cliente);
            }
        }

        public async Task<Cliente> ConsultarCliente(int idCliente)
        {
            var cliente = await _clienteRepository.GetById(idCliente);
            return cliente;
           
        }

    }
}
