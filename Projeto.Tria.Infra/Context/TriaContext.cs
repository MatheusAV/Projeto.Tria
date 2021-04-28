using Microsoft.EntityFrameworkCore;
using Projeto.Tria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Tria.Infra.Context
{
   
    public class TriaContext : DbContext
    {


        public TriaContext(DbContextOptions options) : base(options)
        {

        
        }
           public DbSet<Cliente> Cliente { get; set; }
           public DbSet<ProdutosSrvico> ProdutosSrvico { get; set; }



        // Comandos Code first
        // Add-Migration  NomeMigration
        // Update-DataBase
        // Remove-Migration


    }
}
