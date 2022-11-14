using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Apps.Controllers
{
    public class Appointments : Controller
    {
        public IActionResult DrShedule()
        {
            return View();
        }
        public IActionResult AllAppointments()
        {
            return View();
        }

    }
}
