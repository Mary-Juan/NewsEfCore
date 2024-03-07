using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.Services.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public bool Delete( int id)
        {
            _newsRepository.Delete(id);
            return true;
        }


        public List<NewsViewModel> GetAll()
        {
            return _newsRepository.GetAll();
        }

        public List<NewsViewModel> GetByCategory(int categoryId)
        {
          return  _newsRepository.GetByCategory(categoryId);
        }

        public NewsDetailViewModel GetById(int id)
        {
            return _newsRepository.GetById(id);
        }

        public NewsDetailViewModel Insert(InsertNewsViewModel news)
        {
            var insertedNews = _newsRepository.Insert(news);
            return insertedNews;
        }

        public bool Update(UpdateNewsViewModel news)
        {
            var update = _newsRepository.GetById(news.Id);

            if (update == null)
                return false;

            if (news.Image != null && news.Image.Length > 0)
            {
                string extention = Path.GetExtension(news.Image.FileName).ToLower();
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "NewsImgs", news.Id + extention);

                if (System.IO.File.Exists(filepath))
                {
                    System.IO.File.Delete(filepath);
                }

                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    news.Image.CopyTo(stream);
                }

                news.ImageName = news.Id + extention;
            }

            _newsRepository.Update(news);
            return true;
        }
    }
}
