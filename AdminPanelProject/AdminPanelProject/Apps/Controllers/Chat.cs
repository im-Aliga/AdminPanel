using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class Chat : Controller
    {
        public IActionResult ChatApp()
        {
            return View();
        }
    }
}
