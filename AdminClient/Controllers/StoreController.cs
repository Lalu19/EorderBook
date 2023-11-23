using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace AdminClient.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult CreateStore()
        {
            return View();
        }
        public IActionResult CreateStoreTransaction()
        {
            return View();
        }
        public IActionResult StoreList()
        {
            return View();
        }
        public IActionResult StoreEdit(int storeId)
        {
            ViewBag.storeId = storeId;
            return View();
        }
        public IActionResult StoreTransactionVerify(int storeId)
        {
            ViewBag.storeId = storeId;
            return View();
        }
        public IActionResult TransactionHistory()
        {
            return View();
        }
        public IActionResult StoreNotification(int storeId)
        {
            ViewBag.storeId = storeId;
            return View();
        }
    }
}
