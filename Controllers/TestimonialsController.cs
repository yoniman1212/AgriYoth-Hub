using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class TestimonialsController : Controller
    {
        public IActionResult Testimonials()
        {
            return View();
        }
    }
}
