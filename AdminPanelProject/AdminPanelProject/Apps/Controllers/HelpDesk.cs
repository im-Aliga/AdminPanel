using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Controllers
{
    public class HelpDesk : Controller
    {
        public IActionResult Tickets()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Agents()
        {
            return View();
        }
    }
}
