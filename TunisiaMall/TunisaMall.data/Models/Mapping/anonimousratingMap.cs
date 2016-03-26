using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TunisaMall.data.Models.Mapping
{
    public class anonimousratingMap : EntityTypeConfiguration<anonimousrating>
    {
        public anonimousratingMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("anonimousrating", "pidevtunisiamall");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.idProd).HasColumnName("idProd");
            this.Property(t => t.rate).HasColumnName("rate");
        }
    }
}
