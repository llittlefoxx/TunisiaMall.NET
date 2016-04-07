using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class promotionMap : EntityTypeConfiguration<promotion>
    {
        public promotionMap()
        {
            // Primary Key
            this.HasKey(t => t.idPromotion);

            // Properties
            this.Property(t => t.idPromotion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("promotion", "pidevtunisiamall");
            this.Property(t => t.idPromotion).HasColumnName("idPromotion");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.value).HasColumnName("value");
        }
    }
}
