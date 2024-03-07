using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Contexts.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id=1,
                    Title = "scientific"
                },
                new Category
                {
                    Id=2,
                    Title = "political"
                }
                );
        }
    }
}
