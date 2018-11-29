using CompareRemedios.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class PrecoMap : EntityTypeConfiguration<Preco>
    {
        public PrecoMap()
        {
            HasKey(p => p.Id);
            ToTable("PRECO");

        }

    }
}
