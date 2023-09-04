using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
