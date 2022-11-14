using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class Email : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult ReadEmail()
        {
            return View();
        }
    }
}
