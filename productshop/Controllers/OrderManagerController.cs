using Microsoft.AspNetCore.Mvc;

namespace productshop.Controllers
{
    public class OrderManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
