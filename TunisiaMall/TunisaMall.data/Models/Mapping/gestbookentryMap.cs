using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class gestbookentryMap : EntityTypeConfiguration<gestbookentry>
    {
        public gestbookentryMap()
        {
            // Primary Key
            this.HasKey(t => t.idEntries);

            // Properties
            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("gestbookentry", "pidevtunisiamall");
            this.Property(t => t.idEntries).HasColumnName("idEntries");
            this.Property(t => t.dateEntrie).HasColumnName("dateEntrie");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.user_idUser).HasColumnName("user_idUser");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.gestbookentries)
                .HasForeignKey(d => d.user_idUser);

        }
    }
}
