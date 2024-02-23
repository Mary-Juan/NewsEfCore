using NewsEfCore.DataAccess.Contexts;
using NewsEfCore.DataAccess.Entities;
using NewsEfCore.DataAccess.Repositories.Interfaces;
using NewsEfCore.ViewModels;

namespace NewsEfCore.DataAccess.Repositories
{
    public class UserRpository : IUserRpository
    {
        private readonly NewsContext _db;

        public UserRpository(NewsContext db)
        {
            _db = db;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);

            if (user != null)
            {
                _db.Remove(user);
                return true;
            }

            return false;
        }

        public List<UserViewModel> GetAll()
        {
            return _db.Users.Select(u =>
            new UserViewModel()
            {
                UserName = u.UserName,
                Id = u.Id
            }
            ).ToList();
        }

        public UserDetailViewModel GetById(int id)
        {
          return  _db.Users.Where(u => u.Id == id).Select(u =>
            new UserDetailViewModel()
            {
                Id = u.Id,
                Bio = u.Bio,
                UserName = u.UserName,
                News = u.News.Select(n => new NewsViewModel()
                {
                    Id = n.Id,
                    Title = n.Title,
                    ShortDescription = n.ShortDescription,
                    Image = n.ImageName,
                    CategoryId = n.CategoryId
                }).ToList()
            }).SingleOrDefault();
        }

        public UserDetailViewModel Insert(InsertUserViewModel insert)
        {
            var user = new User()
            {
                UserName = insert.UserName,
                Bio = insert.Bio,
                Password = insert.Password
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return GetById(user.Id);
        }

        public bool Login(LoginUserViewModel login)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);

            if (user == null)
                return false;

            return true;
        }
    }
}
