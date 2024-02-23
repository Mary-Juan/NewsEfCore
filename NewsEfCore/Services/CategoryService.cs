using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.Services.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryViewModel> GetAll()
        {
           return _categoryRepository.GetAll();
        }

        public CategoryDetailViewModel GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }
    }
}
