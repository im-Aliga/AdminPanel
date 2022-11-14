using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Dashboard.Controllers
{
    public class HomeProject : Controller
    {
        public IActionResult Project()
        {
            return View();
        }
    }
}
