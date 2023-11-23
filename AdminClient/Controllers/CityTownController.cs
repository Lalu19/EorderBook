using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CityTownController : Controller
    {
        public IActionResult CreateCity_town()
        {
            return View();
        }
        public IActionResult City_townList()
        {
            return View();
        }
        public IActionResult City_townEdit(int cityId)
        {
            ViewBag.cityId = cityId;
            return View();
        }
    }
}
