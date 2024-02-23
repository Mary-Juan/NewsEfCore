using Microsoft.AspNetCore.Mvc.Rendering;

namespace NewsEfCore.ViewModels
{
    public class InsertNewsViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int WriterId { get; set; }
        public string ShortDescription { get; set; }
        public string ImageName { get; set; } = "0.png";
        public int CategoryId { get; set; }
    }
}
