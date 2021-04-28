using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Tria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Tria.Infra.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("tbl_Cliente");

            builder.HasKey(a => a.IdCliente);

            builder.HasMany(x => x.Produtos)
                .WithMany(x => x.Cliente);
                

             }  
    }
}
