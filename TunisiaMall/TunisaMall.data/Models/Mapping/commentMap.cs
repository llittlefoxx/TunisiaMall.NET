using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using TunisaMall.domain.Entities;

namespace TunisaMall.data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {
            // Primary Key
            this.HasKey(t => t.idComment);

            // Properties
            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("comment", "pidevtunisiamall");
            this.Property(t => t.idComment).HasColumnName("idComment");
            this.Property(t => t.commentDate).HasColumnName("commentDate");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.idPost).HasColumnName("idPost");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasOptional(t => t.post)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idPost);
            this.HasOptional(t => t.user)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idUser);

        }
    }
}
