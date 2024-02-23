using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public List<CategoryViewModel> GetAll();
        public CategoryDetailViewModel GetById(int id);
    }
}
