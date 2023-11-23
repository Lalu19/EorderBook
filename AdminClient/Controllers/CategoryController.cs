using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryCreate()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            return View();
        }
        public IActionResult CategoryEdit(int categoryId)
        {
            ViewBag.categoryId = categoryId;
            return View();
        }
    }
}
