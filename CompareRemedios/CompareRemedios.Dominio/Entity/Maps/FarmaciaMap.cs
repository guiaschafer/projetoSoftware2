
using CompareRemedios.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class FarmaciaMap : EntityTypeConfiguration<Farmacia>
    {
        public FarmaciaMap()
        {
            HasKey(p => p.Id);
            ToTable("FARMACIA");
            
        }
    }
}
