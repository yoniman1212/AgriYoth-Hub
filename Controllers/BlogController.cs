using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
