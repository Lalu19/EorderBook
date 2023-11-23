using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductCreate()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult ProductEdit(int productDetailsId)
        {
            ViewBag.productDetailsId = productDetailsId;
            return View();
        }
    }
}
