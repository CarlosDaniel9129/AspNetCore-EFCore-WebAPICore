using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class Cliente
    {
        //https://docs.microsoft.com/pt-br/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt

        // [NotMapped] -faz com que a propriedade nao seja mapeada e criada no banco, devido a todas prop serem criadas por padrão
        // [Column("blog_id")] -muda o nome de criação no banco de dados
        // [Column(TypeName = "varchar(200)")] -define um tipo e tamanho da coluna
        // [Comment("The URL of the blog")] -add comentarios no banco
        // [MaxLength(500)] -define um tamanho maximo  

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatótio")]
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatótio")]
        [Column(TypeName = "varchar(15)")]
        public string Cpf { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
