using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using AdminApi.Models.App.Location;
using AdminApi.Models.App.StoreNotification;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.DTO.App.StoreNotificationDTO;
using System.Security.Cryptography.Xml;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreNotificationController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<StoreNotification> _storenotificationRepo;
        public StoreNotificationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<StoreNotification> storenotificationRepo)

        {
            _config = config;
            _context = context;
            _storenotificationRepo = storenotificationRepo;

        }
        [HttpPost]
        public IActionResult CreateNotification(StoreNotificationDTO storeNotificationDTO)
        {
            try
            {
                StoreNotification Store = new StoreNotification();
                Store.Status = storeNotificationDTO.Status;
                Store.Remark = storeNotificationDTO.Remark;
                Store.StoreImage = storeNotificationDTO.StoreImage;
                Store.AgentId = storeNotificationDTO.AgentId;
                Store.StoreId = storeNotificationDTO.StoreId;
                Store.CreatedBy = storeNotificationDTO.CreatedBy;
                Store.CreatedOn = System.DateTime.Now;
                var obj = _storenotificationRepo.Insert(Store);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpGet]
        public ActionResult GetStoreNotificationList()
        {
            try
            {
                var list = (from u in _context.StoreNotification
                            join a in _context.Stores on u.StoreId equals a.StoreId
                            join b in _context.Agents on u.AgentId equals b.AgentId
                            select new
                            {
                                u.StoreNotificationId,
                                u.Status,
                                u.Remark,
                                u.StoreImage,
                                u.StoreId,
                                a.StoreName,
                                b.AgentName,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).OrderByDescending(t => t.StoreNotificationId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Userid}")]
        public ActionResult GetStoreNotificationListByUserId(int Userid)
        {
            try
            {
                var list = (from u in _context.StoreNotification
                            join a in _context.Stores on u.StoreId equals a.StoreId
                            join b in _context.Agents on u.AgentId equals b.AgentId
                            select new { u.StoreNotificationId,
                                         u.Status,
                                         u.Remark,
                                         u.StoreImage,
                                         u.StoreId,
                                         a.StoreName,
                                         b.AgentName,
                                         u.CreatedOn,
                                         u.CreatedBy,
                                         u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==Userid).OrderByDescending(t => t.StoreNotificationId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{StoreId}/{Userid}")]
        public ActionResult GetStoreNotificationListStoreIdAndUserId(int StoreId,int Userid)
        {
            try
            {
                var list = (from u in _context.StoreNotification
                            join a in _context.Stores on u.StoreId equals a.StoreId
                            join b in _context.Agents on u.AgentId equals b.AgentId
                            select new
                            {
                                u.StoreNotificationId,
                                u.Status,
                                u.Remark,
                                u.StoreImage,
                                u.StoreId,
                                a.StoreName,
                                b.AgentName,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.StoreId==StoreId && x.CreatedBy==Userid && x.CreatedOn > DateTime.Now.AddDays(-1)).OrderByDescending(t => t.StoreNotificationId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
