using Microsoft.EntityFrameworkCore;
using NewsEfCore.DataAccess.Contexts.Configs;
using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Contexts
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) :base(options)
        {
            
        }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NewsConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
