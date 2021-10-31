using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoProduto> PedidoProdutos { get; set; } // M para M
    }
}
