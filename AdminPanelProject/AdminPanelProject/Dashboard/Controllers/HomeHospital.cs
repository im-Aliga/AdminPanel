using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Dashboard.Controllers
{
    public class HomeHospital : Controller
    {
        public IActionResult Hospital()
        {
            return View();
        }
    }
}
