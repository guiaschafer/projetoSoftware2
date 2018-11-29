using CompareRemedios.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CompareRemedios.Dominio.Entity.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(u => u.Id);
            ToTable("USUARIO");

        }

    }
}
