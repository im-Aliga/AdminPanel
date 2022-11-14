using Microsoft.AspNetCore.Mvc;

namespace Adminpanel.Apps.Controllers
{
    public class Payments : Controller
    {
        public IActionResult AllPayments()
        {
            return View();
        }
        public IActionResult PaymentInvoice()
        {
            return View();
        }
        public IActionResult Cashless()
        {
            return View();
        }
    }
}
