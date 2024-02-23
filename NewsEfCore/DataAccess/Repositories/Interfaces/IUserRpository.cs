using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories.Interfaces
{
    public interface IUserRpository
    {
        public List<UserViewModel> GetAll();
        public UserDetailViewModel GetById(int id);
        public bool Delete(int id);
        public UserDetailViewModel Insert(InsertUserViewModel insert);
        public bool Login(LoginUserViewModel login);
    }
}
