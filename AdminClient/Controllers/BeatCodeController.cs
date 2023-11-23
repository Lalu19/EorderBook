using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BeatCodeController : Controller
    {
        public IActionResult CreateBeatCode()
        {
            return View();
        }
        public IActionResult BeatCodeList()
        {
            return View();
        }
        public IActionResult BeatCodeEdit(int beatCoadId)
        {
            ViewBag.beatCoadId = beatCoadId;
            return View();
        }
    }
}
