using Microsoft.AspNetCore.Mvc;

namespace AdminPanelProject.Apps.Controllers
{
    public class Staff : Controller
    {
        public IActionResult AllStaff()
        {
            return View();
        }
        public IActionResult AddMember()
        {
            return View();
        }
        public IActionResult EditMember()
        {
            return View();
        }
        public IActionResult MemberProfile()
        {
            return View();
        }
        public IActionResult StaffSalary()
        {
            return View();
        }
    }
}
