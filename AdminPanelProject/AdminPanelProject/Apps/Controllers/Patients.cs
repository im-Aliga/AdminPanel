using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Apps.Controllers
{
    public class Patients : Controller
    {
        public IActionResult AllPatients()
        {
            return View();
        }
        public IActionResult AddPatients()
        {
            return View();
        }
        public IActionResult PatientsEdit()
        {
            return View();
        }
        public IActionResult PatientsProfile()
        {
            return View();
        }
    }
}
