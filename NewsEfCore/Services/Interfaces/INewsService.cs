using NewsEfCore.ViewModels;

namespace NewsEfCore.Services.Interfaces
{
    public interface INewsService
    {
        public List<NewsViewModel> GetAll();
        public NewsDetailViewModel GetById(int id);
        public bool Update(UpdateNewsViewModel news);
        public bool Delete(int id);
        public NewsDetailViewModel Insert(InsertNewsViewModel news);
    }
}
