using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Controllers
{
    public class Crm : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Opportunities()
        {
            return View();
        }
        public IActionResult Leads()
        {
            return View();
        }
        public IActionResult Ccustomers()
        {
            return View();
        }
    }
}
