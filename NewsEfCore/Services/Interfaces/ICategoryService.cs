using NewsEfCore.ViewModels;

namespace NewsEfCore.Services.Interfaces
{
    public interface ICategoryService
    {
        public List<CategoryViewModel> GetAll();
        public CategoryDetailViewModel GetById(int id);
    }
}
