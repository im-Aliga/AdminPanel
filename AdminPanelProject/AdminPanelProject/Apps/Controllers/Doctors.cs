using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Apps.Controllers
{
    public class Doctors : Controller
    {
        public IActionResult AllDoctors()
        {
            return View();
        }
        public IActionResult AddDoctors()
        {
            return View();
        }
        public IActionResult DoctorsEdit()
        {
            return View();
        }
        public IActionResult DoctorsProfile()
        {
            return View();
        }
    }
}
