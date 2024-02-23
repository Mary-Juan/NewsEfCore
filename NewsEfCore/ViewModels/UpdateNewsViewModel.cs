namespace NewsEfCore.ViewModels
{
    public class UpdateNewsViewModel
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Body { get; set; }
        public string ShortDescription { get; set; }
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
        public int CategoryId { get; set; }
    }
}
