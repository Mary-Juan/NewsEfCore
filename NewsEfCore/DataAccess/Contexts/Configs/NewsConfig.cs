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
            builder.HasData(
                new News
                {
                    Id = 1,
                    Title = "Folan",
                    Body = " hyjfughgtrdhtrdrtfg",
                    CategoryId = 1,
                    RegisterDate = DateTime.Now,
                    ShortDescription = "htrdt",
                    WriterId = 1,
                    ImageName = "0.png"
                }
                );
        }
    }
}
