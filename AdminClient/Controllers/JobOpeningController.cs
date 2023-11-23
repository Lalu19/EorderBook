using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class JobOpeningController : Controller
    {
        public IActionResult JobOpeningCreate()
        {
            return View();
        }
        public IActionResult JobOpeningView()
        {
            return View();
        }
        public IActionResult JobOpeningEdit(int jobOpeningId)
        {
            ViewBag.jobOpeningId = jobOpeningId;
            return View();
        }
    }
}
