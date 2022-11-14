using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Controllers
{
    public class Ecommerce : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetals()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
