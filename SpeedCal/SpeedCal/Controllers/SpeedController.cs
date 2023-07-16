using Microsoft.AspNetCore.Mvc;

namespace SpeedCal.Controllers
{
    public class SpeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Convert(double speed)
        {
            double speedInKmPerHour = speed * 3.6;
            ViewBag.SpeedInKmPerHour = speedInKmPerHour;
            return View("Result");
        }
    }
}
