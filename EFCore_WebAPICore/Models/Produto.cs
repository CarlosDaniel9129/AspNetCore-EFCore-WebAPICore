using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public decimal Preco { get; set; }
        public List<PedidoProduto> PedidoProdutos { get; set; } // M para M
    }
}
