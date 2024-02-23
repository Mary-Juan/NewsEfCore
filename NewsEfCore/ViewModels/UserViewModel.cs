using NewsEfCore.DataAccess.Entities;

namespace NewsEfCore.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public List<NewsViewModel> News { get; set; }
    }
}
