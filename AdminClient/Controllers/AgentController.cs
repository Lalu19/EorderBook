using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult CreateAgent()
        {
            return View();
        }
        public IActionResult AgentList()
        {
            return View();
        }
        public IActionResult AgentEdit(int agentId)
        {
            ViewBag.agentId = agentId;
            return View();
        }
    }
}
