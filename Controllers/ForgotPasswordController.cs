using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult ForgotPassowrd()
        {
            return View();
        }
    }
}
