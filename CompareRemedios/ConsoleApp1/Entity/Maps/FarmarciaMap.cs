﻿using CompareRemedios.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class FarmarciaMap : EntityTypeConfiguration<Farmacia>
    {
        public FarmarciaMap()
        {
            HasKey(p => p.Id);

            Property(f => f.NomeFantasia)
                .HasColumnName("NomeFantasia")
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}
