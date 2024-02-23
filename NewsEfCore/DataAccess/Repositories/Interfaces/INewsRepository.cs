using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.DataAccess.Repositories.Interfaces
{
    public interface INewsRepository
    {
        public List<News> GetAll();
        public News GetById(int id);
 
    }
}
