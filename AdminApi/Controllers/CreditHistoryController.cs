using AdminApi.DTO.App.CreditHistoryDTO;
using AdminApi.Models.App.CreditHistory;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Text;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CreditHistoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<CreditHistory> _credithistoryRepo;


        public CreditHistoryController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<CreditHistory> credithistoryRepo)
        {
            _config = config;
            _context = context;
            _credithistoryRepo = credithistoryRepo;
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
        public IActionResult TransactionCreate(CreditHistoryDTO creditHistoryDTO)
        {
            try
            {
                CreditHistory creditHistory = new CreditHistory();
                creditHistory.StoreId = creditHistoryDTO.StoreId;
                creditHistory.AgentId = creditHistoryDTO.AgentId;
                creditHistory.CreditBalance = creditHistoryDTO.CreditBalance;
                creditHistory.DebitBalance = creditHistoryDTO.DebitBalance;
                creditHistory.TransactionID = "TN" + GenerateRandomNumber(10);
                creditHistory.TotalOutstanding = creditHistoryDTO.TotalOutstanding;
                creditHistory.TransactionStatus = "Pending";
                creditHistory.Receipt = creditHistoryDTO.Receipt;
                creditHistory.CreatedBy = creditHistoryDTO.CreatedBy;
                creditHistory.CreatedOn = System.DateTime.Now;
                var obj = _credithistoryRepo.Insert(creditHistory);

                var store = _context.Stores.SingleOrDefault(opt => opt.StoreId == creditHistory.StoreId);
                store.CreditBalance = creditHistory.TotalOutstanding;
                store.UpdatedBy = creditHistory.CreatedBy;
                store.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{StoreId}/{UserId}")]
        public ActionResult GetCrditAndDebitBlanceListByUserId(int StoreId,int UserId)
        {
            try
            {
                var list = (from u in _context.CreditHistory
                            join a in _context.Agents on u.AgentId equals a.AgentId
                            join b in _context.Stores on u.StoreId equals b.StoreId
                            select new { u.CreditHistoryId,
                                u.TransactionID,
                                u.StoreId,
                                b.StoreName,
                                u.CreatedOn,
                                u.CreditBalance,
                                u.DebitBalance,
                                u.TotalOutstanding,
                                u.TransactionStatus,
                                u.Receipt,
                                u.CreatedBy,
                                a.AgentName,
                                u.IsDeleted }).Where(x => x.IsDeleted == false && x.StoreId==StoreId && x.CreatedBy == UserId).OrderByDescending(t => t.CreditHistoryId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{StoreId}/{AgentId}/{UserId}")]
        public ActionResult GetCrditAndDebitBlanceHistoryByStoreId(int StoreId, int AgentId, int UserId)
        {
            try
            {
                var list = (from u in _context.CreditHistory
                            join a in _context.Agents on u.AgentId equals a.AgentId
                            join b in _context.Stores on u.StoreId equals b.StoreId
                            select new
                            {
                                u.CreditHistoryId,
                                u.TransactionID,
                                u.StoreId,
                                b.StoreName,
                                u.CreatedOn,
                                u.CreditBalance,
                                u.DebitBalance,
                                u.TotalOutstanding,
                                u.TransactionStatus,
                                u.Receipt,
                                u.CreatedBy,
                                u.AgentId,
                                a.AgentName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.TransactionStatus== "Approve" && x.StoreId==StoreId &&x.AgentId == AgentId && x.CreatedBy == UserId).OrderByDescending(t => t.CreditHistoryId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetAllCrditHistoryByUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.CreditHistory
                            join a in _context.Agents on u.AgentId equals a.AgentId
                            join b in _context.Stores on u.StoreId equals b.StoreId
                            join c in _context.Users on u.UpdatedBy equals c.UserId
                            select new
                            {
                                u.CreditHistoryId,
                                u.TransactionID,
                                u.StoreId,
                                b.StoreName,
                                u.CreatedOn,
                                u.CreditBalance,
                                u.DebitBalance,
                                u.TotalOutstanding,
                                u.TransactionStatus,
                                u.Receipt,
                                u.CreatedBy,
                                u.AgentId,
                                c.FullName,
                                a.AgentName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.TransactionStatus == "Approve" && x.CreatedBy == UserId).OrderByDescending(t => t.CreditHistoryId);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{ApproveBy}")]
        public ActionResult ApproveTransction(int Id, int ApproveBy)
        {
            try
            {
                var objabout = _context.CreditHistory.SingleOrDefault(opt => opt.CreditHistoryId == Id);
                objabout.TransactionStatus = "Approve";
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

        [HttpGet("{Id}/{ApproveBy}")]
        public ActionResult DeclineTransction(int Id, int ApproveBy)
        {
            try
            {
                var objabout = _context.CreditHistory.SingleOrDefault(opt => opt.CreditHistoryId == Id);
                objabout.TransactionStatus = "Decline";
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
