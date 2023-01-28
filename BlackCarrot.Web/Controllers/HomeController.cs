using BlackCarrot.Data.Contexts;
using BlackCarrot.Data.Models;
using BlackCarrot.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlackCarrot.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProductsContext _context;

        public HomeController(ProductsContext Context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = Context;
        }

        public IActionResult Index()
        {
            List<ProductModel> products = _context.Products.ToList();
            return View(products);
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