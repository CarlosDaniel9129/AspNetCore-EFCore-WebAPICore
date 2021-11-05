using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(200)")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(100)")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public List<PedidoProduto> PedidoProdutos { get; set; } // M para M
    }
}
