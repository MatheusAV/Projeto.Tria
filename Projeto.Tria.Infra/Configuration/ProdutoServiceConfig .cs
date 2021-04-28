using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Tria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Tria.Infra.Configuration
{
    public class ProdutoServiceConfig : IEntityTypeConfiguration<ProdutosSrvico>
    {
        public void Configure(EntityTypeBuilder<ProdutosSrvico> builder)
        {
            builder.ToTable("tbl_ProdutoServico");

            builder.HasKey(a => a.IdProduto);

            builder.HasMany(x => x.Cliente)
                .WithMany(x => x.Produtos);

             }  
    }
}
