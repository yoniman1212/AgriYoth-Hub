using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
