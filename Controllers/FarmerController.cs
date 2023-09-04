using Microsoft.AspNetCore.Mvc;

namespace AgriYoth_Hub.Controllers
{
    public class FarmerController : Controller
    {
        public IActionResult Farmer()
        {
            return View();
        }
    }
}
