using Microsoft.AspNetCore.Mvc;
using NewsEfCore.Services.Interfaces;

namespace NewsEfCore.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly ICategoryService _categoryService;

        public NewsController(INewsService newsService, ICategoryService categoryService)
        {
            _newsService = newsService;
            _categoryService = categoryService;
        }

        public IActionResult GetByCategory(int id)
        {
            ViewBag.Category = _categoryService.GetById(id).Title;
            return View(_newsService.GetByCategory(id));
        }

        public IActionResult GetDetail(int id)
        {
            return View(_newsService.GetById(id));
        }
       
    }
}
