using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Contexts.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "Admin",
                    Password = "1234",
                    Bio = "Administrator",
                    RoleId = 1
                }
                );
        }
    }
}
