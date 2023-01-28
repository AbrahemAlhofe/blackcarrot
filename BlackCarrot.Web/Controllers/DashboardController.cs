using Microsoft.AspNetCore.Mvc;

namespace BlackCarrot.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
