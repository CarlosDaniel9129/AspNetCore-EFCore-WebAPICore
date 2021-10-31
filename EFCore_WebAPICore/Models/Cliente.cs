using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatótio")]
        public string Cpf { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
