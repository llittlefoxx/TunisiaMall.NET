using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class categoryMap : EntityTypeConfiguration<category>
    {
        public categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.idCategory);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.libelle)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("category", "pidevtunisiamall");
            this.Property(t => t.idCategory).HasColumnName("idCategory");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.libelle).HasColumnName("libelle");
        }
    }
}
