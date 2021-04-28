using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Tria.Domain.Entities;
using Projeto.Tria.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Tria.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _clienteService;

        public ClienteController (IClienteService clienteService )
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var clientes = await _clienteService.Listar();

            return Ok (clientes);
        }

        [HttpPost]
        public async Task Editar([FromBody] Cliente cliente)
        {
           await _clienteService.Editar(cliente);
        }

        [HttpPost]
        public async Task Adicionar([FromBody]Cliente cliente)
        {
            await _clienteService.Adicionar(cliente);
        }

        [HttpGet]
        public async Task Deletar(int idCliente)
        {
            await _clienteService.Deletar(idCliente);
            
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarCliente(int idCliente)
        {
           var cliente = await _clienteService.ConsultarCliente(idCliente);
           
            return Ok(cliente);
        }

    }
}
