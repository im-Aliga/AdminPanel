using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Controllers
{
    public class Analytics : Controller
    {
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
    }
}
