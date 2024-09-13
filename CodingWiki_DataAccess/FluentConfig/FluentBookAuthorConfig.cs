using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookAuthorConfig : IEntityTypeConfiguration<Fluent_BookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookAuthorMap> modelBuilder)
        {
            modelBuilder.HasKey(u => new { u.Author_Id, u.IDBook });
            modelBuilder.HasOne(u => u.Book).WithMany(u => u.BookAuthorMap)
                .HasForeignKey(u => u.IDBook);
            modelBuilder.HasOne(u => u.Author).WithMany(u => u.BookAuthorMap)
                .HasForeignKey(u => u.Author_Id);
        }
    }
}
