using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class Contact : Controller
    {
        public IActionResult ContactList()
        {
            return View();
        }
    }
}
