using System.Security.Principal;

namespace tech_test_payment_api.Entities
{
    public class VendaItemEntity : EntityBase
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int IdVenda { get; set; }

        public virtual ProdutoEntity Produto { get; set; }
    }
}
