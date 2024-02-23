namespace NewsEfCore.ViewModels
{
    public class UserDetailViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public List<NewsViewModel> News { get; set; }
    }
}
