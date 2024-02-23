using Microsoft.EntityFrameworkCore;

namespace NewsEfCore.DataAccess.Contexts
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) :base(options)
        {
            
        }


    }
}
