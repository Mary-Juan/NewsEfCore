using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories.Interfaces
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NewsContext _db;

        public CategoryRepository(NewsContext db)
        {
            _db = db;
        }

        public List<CategoryViewModel> GetAll()
        {
            return _db.Categories.Select(c =>
            new CategoryViewModel()
            {
                Id = c.Id,
                Title = c.Title
            }).ToList();
        }

        public CategoryDetailViewModel GetById(int id)
        {
            return _db.Categories.Where(c => c.Id == id).Select(
                c => new CategoryDetailViewModel()
                {
                    Id = c.Id,
                    Title = c.Title,
                    News = c.News.Select(n => new NewsViewModel()
                    {
                       Id = n.Id,
                       Title = n.Title,
                       Image = n.ImageName,
                       ShortDescription = n.ShortDescription,
                       CategoryId = n.CategoryId
                    }).ToList()
                }
                ).SingleOrDefault();
        }
    }
}
