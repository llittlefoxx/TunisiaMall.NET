using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class imageMap : EntityTypeConfiguration<image>
    {
        public imageMap()
        {
            // Primary Key
            this.HasKey(t => t.idImage);

            // Properties
            this.Property(t => t.imagePath)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("images", "pidevtunisiamall");
            this.Property(t => t.idImage).HasColumnName("idImage");
            this.Property(t => t.imagePath).HasColumnName("imagePath");
            this.Property(t => t.idProduct).HasColumnName("idProduct");

            // Relationships
            this.HasOptional(t => t.product)
                .WithMany(t => t.images)
                .HasForeignKey(d => d.idProduct);

        }
    }
}
