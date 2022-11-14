using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class Calendar : Controller
    {
        public IActionResult AppCalendar()
        {
            return View();
        }
    }
}
