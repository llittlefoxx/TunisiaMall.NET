using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class storeMap : EntityTypeConfiguration<store>
    {
        public storeMap()
        {
            // Primary Key
            this.HasKey(t => t.idStroe);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.tel)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("store", "pidevtunisiamall");
            this.Property(t => t.idStroe).HasColumnName("idStroe");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.openingDay).HasColumnName("openingDay");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.tel).HasColumnName("tel");
            this.Property(t => t.category_fk).HasColumnName("category_fk");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasMany(t => t.events)
                .WithMany(t => t.stores)
                .Map(m =>
                    {
                        m.ToTable("storeevent", "pidevtunisiamall");
                        m.MapLeftKey("idStore");
                        m.MapRightKey("idEvent");
                    });

            this.HasOptional(t => t.category)
                .WithMany(t => t.stores)
                .HasForeignKey(d => d.category_fk);
            this.HasOptional(t => t.user)
                .WithMany(t => t.stores)
                .HasForeignKey(d => d.idUser);

        }
    }
}
