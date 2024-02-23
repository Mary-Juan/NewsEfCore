using NewsEfCore.DataAccess.Entities;
using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories.Interfaces
{
    public interface INewsRepository
    {
        public List<NewsViewModel> GetAll();
        public NewsDetailViewModel GetById(int id);
        public bool UpdateNews(UpdateNewsViewModel news);
        public bool Delete(int id);
        public NewsDetailViewModel Insert(InsertNewsViewModel news);
    }
}
