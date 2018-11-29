using CompareRemedios.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            HasKey(p => p.Id);
            ToTable("PRODUTO");

        }

    }
}
