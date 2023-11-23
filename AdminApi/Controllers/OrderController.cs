using AdminApi.DTO.App.StoreMasterDTO;
using AdminApi.Models.App.StoreMaster;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App.Agent;
using AdminApi.DTO.App.AgentDTO;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Security.Cryptography;
using AdminApi.Models.App.Order;
using AdminApi.Models.App.OrderMaster;
using AdminApi.DTO.App.OrderDTO;
using System.Security.Cryptography.Xml;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Order> _OrderRepo;
        private readonly ISqlRepository<OrderDetails> _OrderDetailsRepo;
        public OrderController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Order> orderRepo,
                                ISqlRepository<OrderDetails> orderdetailsRepo
                               )
        {
            _config = config;
            _context = context;
            _OrderRepo = orderRepo;
            _OrderDetailsRepo = orderdetailsRepo;

        }
        private string GenerateRandomNumber(int digitCount)
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < digitCount; i++)
            {
                stringBuilder.Append(random.Next(0, 10));
            }
            return stringBuilder.ToString();
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDTO orderDTO)
        {
            
            try
            {
                Order order = new Order();
                order.AutoOrderId = "OD" + GenerateRandomNumber(10);
                order.StoreId = orderDTO.StoreId;
                order.AgentId = orderDTO.AgentId;
                order.Status = "Order Placed";
                order.TotalPrice = orderDTO.TotalPrice;
                order.CreatedBy = orderDTO.CreatedBy;
                var obj = _OrderRepo.Insert(order);

                for (int i = 0; i < orderDTO.OrderDetails.Count; i++)
                {
                    OrderDetails orderdetails = new OrderDetails();
                    orderdetails.OrderId = obj.OrderId;
                    orderdetails.BrandId = orderDTO.OrderDetails[i].BrandId;
                    orderdetails.CategoryId = orderDTO.OrderDetails[i].CategoryId;
                    orderdetails.ProductDetailsId = orderDTO.OrderDetails[i].ProductDetailsId;
                    orderdetails.PackagingType = orderDTO.OrderDetails[i].PackagingType;
                    orderdetails.Quantity = orderDTO.OrderDetails[i].Quantity;
                    orderdetails.Mrp = orderDTO.OrderDetails[i].Mrp;
                    orderdetails.SellingPrice = orderDTO.OrderDetails[i].SellingPrice;
                    orderdetails.OrderStatus = "Order Placed";
                    orderdetails.CreatedBy = orderDTO.CreatedBy;
                    var orderdetailsobj = _OrderDetailsRepo.Insert(orderdetails);
                }
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetAllOrderListbyOrderId(int UserId)
        {
            try
            {
                var list = (from u in _context.OrderDetails
                            join a in _context.Categorys on u.CategoryId equals a.CategoryId
                            join b in _context.ProductDetailss on u.ProductDetailsId equals b.ProductDetailsId
                            join c in _context.Orders on u.OrderId equals c.OrderId
                            join d in _context.Brands on u.BrandId equals d.BrandId
                            join e in _context.Stores on c.StoreId equals e.StoreId
                            select new
                            {
                                u.OrderDetailsId,
                                u.OrderId,
                                c.AutoOrderId,
                                d.BrandName,
                                a.CategoryName,
                                b.ProductDetailsName,
                                b.image,
                                u.Quantity,
                                u.PackagingType,
                                e.StoreName,
                                u.Mrp,
                                u.SellingPrice,
                                u.OrderStatus,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CreatedBy == UserId).OrderByDescending(t => t.OrderDetailsId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetOrderListbyUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Orders
                            join a in _context.Stores on u.StoreId equals a.StoreId
                            join b in _context.Agents on u.AgentId equals b.AgentId
                            select new
                            {
                                u.OrderId,
                                u.AutoOrderId,
                                u.Status,
                                a.StoreName,
                                b.AgentName,
                                u.TotalPrice,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CreatedBy == UserId).OrderByDescending(t => t.OrderId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{OrderId}")]
        public ActionResult GetOrderListbyOrderId(int OrderId)
        {
            try
            {
                var list = (from u in _context.OrderDetails
                            join a in _context.Categorys on u.CategoryId equals a.CategoryId
                            join b in _context.ProductDetailss on u.ProductDetailsId equals b.ProductDetailsId
                            join c in _context.Orders on u.OrderId equals c.OrderId
                            join d in _context.Brands on u.BrandId equals d.BrandId
                            join e in _context.Stores on c.StoreId equals e.StoreId
                            select new
                            {
                                u.OrderDetailsId,
                                u.OrderId,
                                c.AutoOrderId,
                                d.BrandName,
                                a.CategoryName,
                                b.ProductDetailsName,
                                b.image,
                                u.Quantity,
                                u.PackagingType,
                                e.StoreName,
                                u.Mrp,
                                u.SellingPrice,
                                u.OrderStatus,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.OrderId==OrderId).OrderByDescending(t => t.OrderDetailsId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{ApproveBy}")]
        public ActionResult DeliverdOrder(int Id, int ApproveBy)
        {
            try
            {
                var objabout = _context.CreditHistory.SingleOrDefault(opt => opt.CreditHistoryId == Id);
                objabout.TransactionStatus = "Order Delivered";
                objabout.UpdatedBy = ApproveBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
