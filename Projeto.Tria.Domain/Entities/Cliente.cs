using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Tria.Domain.Entities
{
     public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeDaEmpresa { get; set; }
        public string NomeDoCliente { get; set; }
        public string Tel  { get; set; }

        public string E_mail { get; set; }
        public string Conteudo { get; set; }
        public DateTime DtAtendimento { get; set; }

        public string HrAtendimento  { get; set; }

        public DateTime? DtAlteracao { get; set; }

        public int IdProduto { get; set; }

        public List<ProdutosSrvico> Produtos   { get; set; }

    }
}
