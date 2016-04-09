using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class subcategoryMap : EntityTypeConfiguration<subcategory>
    {
        public subcategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.idSubCategory);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.libelle)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("subcategory", "pidevtunisiamall");
            this.Property(t => t.idSubCategory).HasColumnName("idSubCategory");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.libelle).HasColumnName("libelle");
            this.Property(t => t.idCategory).HasColumnName("idCategory");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.subcategories)
                .HasForeignKey(d => d.idCategory);

        }
    }
}
