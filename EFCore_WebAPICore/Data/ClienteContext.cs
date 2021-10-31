using EFCore_WebAPICore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebAPICore.Data
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // -deve-se dizer ao entity que esta sendo usado M para M, uso de chave composta
        public DbSet<PedidoProduto> PedidoProdutos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // -é possivel usar essa capacidade devido ao Entity.SQLServer que está em uso nas dependencias

            // -pode se colocar qualquer name em Catalog que o banco é criado sozinho
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFWebAPI;Integrated Security=True");
        }

        // -para permitir chave composta 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PedidoProduto>(entity =>
            {
                // -tem chave, e sera composta pela batalhaId e pelo HeroiId
                entity.HasKey(e => new { e.ProdutoId, e.PedidoId });
            });
        }
    }
}
