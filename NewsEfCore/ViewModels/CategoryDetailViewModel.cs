namespace NewsEfCore.ViewModels
{
    public class CategoryDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<NewsViewModel> News { get; set; }

    }
}
