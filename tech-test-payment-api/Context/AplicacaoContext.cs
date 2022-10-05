using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Context
{
    public class AplicacaoContext : DbContext
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext> options) : base(options)
        {

        }

        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<VendaEntity> Vendas { get; set; }
        public DbSet<VendaItemEntity> VendasItens { get; set; }
        public DbSet<VendedorEntity> Vendedores { get; set; }

    }
}
