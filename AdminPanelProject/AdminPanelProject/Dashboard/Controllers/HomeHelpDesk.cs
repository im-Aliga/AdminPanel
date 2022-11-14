using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Dashboard.Controllers
{
    public class HomeHelpDesk : Controller
    {
        public IActionResult Helpdesk()
        {
            return View();
        }
    }
}
