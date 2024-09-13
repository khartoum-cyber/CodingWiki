using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.FluentConfig
{
    internal class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
    {
        public void Configure(EntityTypeBuilder<Fluent_Publisher> modelBuilder)
        {
            modelBuilder.Property(u => u.Name).IsRequired();
            modelBuilder.HasKey(u => u.Publisher_Id);
        }
    }
}
