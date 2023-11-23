using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace AdminClient.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult CreateCountry()
        {
            return View();
        }
        public IActionResult CountryList()
        {
            return View();
        }
        public IActionResult CountryEdit(int CountryId)
        {
            ViewBag.CountryId = CountryId;
            return View();
        }
    }
}
