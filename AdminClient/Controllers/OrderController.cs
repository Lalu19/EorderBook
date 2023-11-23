using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult AllOrderList()
        {
            return View();
        }
        public IActionResult OrderList()
        {
            return View();
        }
        public IActionResult ProductList(int orderId)
        {
            ViewBag.orderId = orderId;
            return View();
        }
    }
}
