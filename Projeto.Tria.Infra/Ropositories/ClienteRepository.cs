using Projeto.Tria.Domain.Entities;
using Projeto.Tria.Infra.Context;
using Projeto.Tria.Infra.Ropositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Tria.Infra.Ropositories
{
    

    public class ClienteRepository : Repository<Cliente>, IClienteRepository { 
        public ClienteRepository(TriaContext context) : base(context)
        {
        }

    }
}
