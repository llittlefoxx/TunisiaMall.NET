using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class postMap : EntityTypeConfiguration<post>
    {
        public postMap()
        {
            // Primary Key
            this.HasKey(t => t.idPost);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("post", "pidevtunisiamall");
            this.Property(t => t.idPost).HasColumnName("idPost");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.posts)
                .HasForeignKey(d => d.idUser);

        }
    }
}
