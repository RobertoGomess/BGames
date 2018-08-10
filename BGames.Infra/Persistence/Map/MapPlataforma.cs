using BGames.Entiteis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BGames.Infra.Persistence.Map
{
    public class MapPlataforma : EntityTypeConfiguration<Plataforma>
    {
        public MapPlataforma()
        {
            ToTable("Plataforma");

            Property(p => p.Nome).HasMaxLength(50).IsRequired();

        }


    }
}
