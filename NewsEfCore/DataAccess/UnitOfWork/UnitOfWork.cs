using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.DataAccess.Repositories;
using NewsEfCore.DataAccess.Repositories.Interfaces;

namespace NewsEfCore.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NewsContext _db;
        public IUserRpository UserRepository { get; }
        public INewsRepository NewsRepository { get; }
        public ICategoryRepository CategoryRepository { get; }

        public UnitOfWork(NewsContext db)
        {
            _db = db;
            UserRepository = new UserRpository(db);
            NewsRepository = new NewsRepository(db);
            CategoryRepository = new CategoryRepository(db);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
