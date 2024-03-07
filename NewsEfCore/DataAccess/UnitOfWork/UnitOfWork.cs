using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.DataAccess.Repositories;
using NewsEfCore.DataAccess.Repositories.Interfaces;

namespace NewsEfCore.DataAccess.UnitOfWork
{
    public class UnitOfWork 
    {
        private readonly NewsContext _db;

        public UnitOfWork(NewsContext db)
        {
            _db = db;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
