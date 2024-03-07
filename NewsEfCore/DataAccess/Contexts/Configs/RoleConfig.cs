using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Contexts.Configs
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = 1,
                    Title = "Admin"
                },
                new Role
                {
                    Id = 2,
                    Title = "User"
                }
                );
        }
    }
}
