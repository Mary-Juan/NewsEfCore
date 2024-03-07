using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.DataAccess.UnitOfWork;
using NewsEfCore.Services.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        //private readonly UnitOfWork _unitOfWork;

        public NewsService(INewsRepository newsRepository/*, UnitOfWork unitOfWork*/)
        {
            _newsRepository = newsRepository;
            //_unitOfWork = unitOfWork;
        }

        public bool Delete( int id)
        {
            _newsRepository.Delete(id);
            //_unitOfWork.SaveChanges();
            return true;
        }


        public List<NewsViewModel> GetAll()
        {
            return _newsRepository.GetAll();
        }

        public NewsDetailViewModel GetById(int id)
        {
            return _newsRepository.GetById(id);
        }

        public NewsDetailViewModel Insert(InsertNewsViewModel news)
        {
            var insertedNews = _newsRepository.Insert(news);
            //_unitOfWork.SaveChanges();
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
            //_unitOfWork.SaveChanges();
            return true;
        }
    }
}
