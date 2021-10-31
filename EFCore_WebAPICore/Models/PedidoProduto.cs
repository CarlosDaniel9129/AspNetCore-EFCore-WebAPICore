using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Models
{
    public class PedidoProduto
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal Preco { get; set; } // -caso o preço do Produto se altere, deve ter o preço antigo do produto
    }
}
