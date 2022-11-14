using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Authentication.Controllers
{
    public class Authentication : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult LogInAlt()
        {
            return View();
        }
    }
}
