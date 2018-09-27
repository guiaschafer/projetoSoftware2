using CompareRemedios.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class FarmarciaMap : IEntityTypeConfiguration<Farmacia>
    {
        public void Configure(EntityTypeBuilder<Farmacia> builder)
        {
            builder.HasKey(f => f.Id);                

            builder.Property(f => f.NomeFantasia)
                .HasColumnName("NomeFantasia")
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}
