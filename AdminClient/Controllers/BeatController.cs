using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BeatController : Controller
    {
        public IActionResult CreateBeat()
        {
            return View();
        }
        public IActionResult BeatList()
        {
            return View();
        }
        public IActionResult BeatEdit(int beatId)
        {
            ViewBag.beatId = beatId;
            return View();
        }
    }
}
