using Microsoft.AspNetCore.Mvc;
using NewsEfCore.Models;
using NewsEfCore.Services.Interfaces;
using System.Diagnostics;

namespace NewsEfCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsService _newsService;
        private readonly ICategoryService _categoryService;


        public HomeController(ILogger<HomeController> logger, INewsService newsService, ICategoryService categoryService)
        {
            _logger = logger;
            _newsService = newsService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View(_newsService.GetByCategory(1));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
