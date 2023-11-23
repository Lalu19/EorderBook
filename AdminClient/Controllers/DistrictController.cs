using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class DistrictController : Controller
    {
        public IActionResult CreateDistrict()
        {
            return View();
        }
        public IActionResult DistrictList()
        {
            return View();
        }
        public IActionResult DistrictEdit(int districtId)
        {
            ViewBag.districtId = districtId;
            return View();
        }
    }
}
