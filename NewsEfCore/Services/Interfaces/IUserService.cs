using NewsEfCore.ViewModels;

namespace NewsEfCore.Services.Interfaces
{
    public interface IUserService
    {
        public UserDetailViewModel Register(InsertUserViewModel register);
        public bool LoginUser(LoginUserViewModel login);
    }
}
