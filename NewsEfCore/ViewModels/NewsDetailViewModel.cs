namespace NewsEfCore.ViewModels
{
    public class NewsDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Image { get; set; }
        public UserViewModel Writer { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
