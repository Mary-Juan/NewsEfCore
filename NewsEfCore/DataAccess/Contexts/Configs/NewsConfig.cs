using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Contexts.Configs
{
    public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasOne(n => n.Category).WithMany(c => c.News).HasForeignKey(n => n.CategoryId);
            builder.HasOne(n => n.Witer).WithMany(c => c.News).HasForeignKey(n => n.WriterId);
        }
    }
}
