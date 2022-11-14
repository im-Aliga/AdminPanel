using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Dashboard.Controllers
{
    public class HomeEcommerce : Controller
    {
        public IActionResult Ecommerce()
        {
            return View();
        }
    }
}
