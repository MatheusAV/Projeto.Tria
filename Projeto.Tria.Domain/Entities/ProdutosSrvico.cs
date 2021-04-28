using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Tria.Domain.Entities
{
   public class ProdutosSrvico
    {
        [Key]
        public int IdProduto { get; set; }
        public string nmProduto { get; set; }

        public List<Cliente> Cliente { get; set; }


    }
}
