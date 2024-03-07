using Microsoft.EntityFrameworkCore;
using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.DataAccess.Entities;
using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsContext _db;
        public NewsRepository(NewsContext db)
        {
            _db = db;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);

            if (user != null)
            {
                _db.Remove(user);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<NewsViewModel> GetAll()
        {
            return _db.News.Select(n =>
             new NewsViewModel()
             {
                 Id = n.Id,
                 Title = n.Title,
                 ShortDescription = n.ShortDescription,
                 Image = n.ImageName,
                 CategoryId = n.CategoryId
             }).ToList();
        }

        public List<NewsViewModel> GetByCategory(int categoryId)
        {
            return _db.News.Where(n => n.CategoryId == categoryId).Select(n => 
            new NewsViewModel
            {
                CategoryId = n.CategoryId,
                Id = n.Id,
                Image = n.ImageName,
                ShortDescription = n.ShortDescription,
                Title = n.Title
            }
            ).ToList();
        }

        public NewsDetailViewModel GetById(int id)
        {
            return _db.News.Where(n => n.Id == id).Select(n =>
             new NewsDetailViewModel()
             {
                 Id = n.Id,
                 Title = n.Title,
                 Body = n.Body,
                 RegisterDate = n.RegisterDate,
                 Writer = new UserViewModel()
                 {
                     Id = n.WriterId,
                     UserName = n.Witer.UserName
                 },
                 Category = new CategoryViewModel()
                 {
                     Id = n.CategoryId,
                     Title = n.Category.Title
                 }
             }
            ).SingleOrDefault();
        }

        public NewsDetailViewModel Insert(InsertNewsViewModel news)
        {
            var newNews = new News()
            {
                Title = news.Title,
                Body = news.Body,
                ShortDescription = news.ShortDescription,
                WriterId = news.WriterId,
                RegisterDate = DateTime.Now,
                ImageName = news.ImageName,
                CategoryId = news.CategoryId
            };

            _db.Add(news);
            _db.SaveChanges();

            return GetById(newNews.Id);
        }

     

        public void Update(UpdateNewsViewModel news)
        {
            var update = _db.News.Find(news.Id);
            update.Title = news.Title;
            update.ShortDescription = news.ShortDescription;
            update.Body = news.Body;
            update.ImageName = news.ImageName;
            update.CategoryId = news.CategoryId;
            _db.SaveChanges();
        }
    }
}
