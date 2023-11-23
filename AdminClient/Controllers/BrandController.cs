using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult BrandCreate()
        {
            return View();
        }
        public IActionResult BrandList()
        {
            return View();
        }
        public IActionResult BrandEdit(int brandId)
        {
            ViewBag.brandId = brandId;
            return View();
        }
    }
}
