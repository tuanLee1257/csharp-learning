using Microsoft.AspNetCore.Mvc;

namespace productshop.Controllers
{
    public class UserManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
