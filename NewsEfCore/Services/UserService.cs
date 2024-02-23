using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.DataAccess.UnitOfWork;
using NewsEfCore.Services.Interfaces;
using NewsEfCore.Utilities;
using NewsEfCore.ViewModels;

namespace NewsEfCore.Services
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IUserRpository _userRpository;

        public UserService(UnitOfWork unitOfWork, IUserRpository userRpository)
        {
            _unitOfWork = unitOfWork;
            _userRpository = userRpository;

        }

        public bool LoginUser(LoginUserViewModel login)
        {
            return _userRpository.Login(login);
        }

        public UserDetailViewModel Register(InsertUserViewModel register)
        {
            register.Password = PasswordHelper.EncodePasswordMd5(register.Password);
            return _userRpository.Insert(register);
        }
    }
}
