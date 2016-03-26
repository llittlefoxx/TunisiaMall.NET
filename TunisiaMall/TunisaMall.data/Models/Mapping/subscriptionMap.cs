using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TunisaMall.data.Models.Mapping
{
    public class subscriptionMap : EntityTypeConfiguration<subscription>
    {
        public subscriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.idEvent, t.idSubscription, t.idUser });

            // Properties
            this.Property(t => t.idEvent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idSubscription)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("subscriptions", "pidevtunisiamall");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idSubscription).HasColumnName("idSubscription");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasRequired(t => t.@events)
                .WithMany(t => t.subscriptions)
                .HasForeignKey(d => d.idEvent);
            this.HasRequired(t => t.user)
                .WithMany(t => t.subscriptions)
                .HasForeignKey(d => d.idUser);

        }
    }
}
