using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class ivce : Controller
    {
        public IActionResult InVoice()
        {
            return View();
        }
    }
}
