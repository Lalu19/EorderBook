using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using AdminApi.Models.App.BeatMaster;
using AdminApi.DTO.App.BeatMasterDTO;
using AdminApi.Models.App.StoreMaster;
using AdminApi.DTO.App.StoreMasterDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Store> _StoreRepo;

        public StoreController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<Store> storeRepo)
        {
            _config = config;
            _context = context;
            _StoreRepo = storeRepo;
        }
        [HttpPost]
        public IActionResult StoreRepoCreate(CreateStoreDTO createStoreDTO)
        {
            try
            {
                Store store = new Store();
                store.BeatId = createStoreDTO.BeatId;
                store.AgentId = createStoreDTO.AgentId;
                store.StoreName = createStoreDTO.StoreName;
                store.OwnerName = createStoreDTO.OwnerName;
                store.ContactPersonName = createStoreDTO.ContactPersonName;
                store.Adress = createStoreDTO.Adress;
                store.PinCode = createStoreDTO.PinCode;
                store.PhoneNumber = createStoreDTO.PhoneNumber;
                store.WhatsAppNumber = createStoreDTO.WhatsAppNumber;
                store.Landmark = createStoreDTO.Landmark;
                store.Image = createStoreDTO.Image;
                store.CreditBalance = createStoreDTO.CreditBalance;
                store.CreatedBy = createStoreDTO.CreatedBy;
                store.CreatedOn = System.DateTime.Now;
                var obj = _StoreRepo.Insert(store);
                return Ok(obj);
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetStoreList()
        {
            try
            {
                var list = (from u in _context.Stores
                            join a in _context.Beats on u.BeatId equals a.BeatId
                            join c in _context.Agents on u.CreatedBy equals c.AgentId
                            join b in _context.Users on c.CreatedBy equals b.UserId

                            select new { 
                                b.UserId,
                                b.UserName,
                                c.AgentId,
                                c.AgentName,
                                u.StoreId, 
                                u.StoreName, 
                                a.BeatName,
                                u.BeatId,
                                u.OwnerName,
                                u.ContactPersonName,
                                u.Adress,
                                u.PinCode,
                                u.PhoneNumber,
                                u.WhatsAppNumber,
                                u.Landmark,
                                u.Image,
                                u.CreditBalance,
                                u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetStoreListByUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Stores
                            join a in _context.Beats on u.BeatId equals a.BeatId
                            join c in _context.Agents on u.AgentId equals c.AgentId
                            join b in _context.Users on c.CreatedBy equals b.UserId

                            select new
                            {
                                b.UserId,
                                b.UserName,
                                c.AgentId,
                                c.AgentName,
                                u.StoreId,
                                u.StoreName,
                                a.BeatName,
                                u.BeatId,
                                u.OwnerName,
                                u.ContactPersonName,
                                u.Adress,
                                u.PinCode,
                                u.PhoneNumber,
                                u.WhatsAppNumber,
                                u.Landmark,
                                u.Image,
                                u.CreditBalance,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpGet("{BeatId}/{UserId}")]
        public ActionResult GetStoreListbybeatid(int BeatId,int UserId)
        {
            try
            {
                var list = (from u in _context.Stores
                            join a in _context.Beats on u.BeatId equals a.BeatId
                            join c in _context.Agents on u.CreatedBy equals c.AgentId
                            join b in _context.Users on c.CreatedBy equals b.UserId
                            

                            select new
                            {
                                b.UserId,
                                b.UserName,
                                c.AgentId,
                                c.AgentName,
                                u.StoreId,
                                a.BeatId,
                                a.BeatName,
                                u.StoreName,
                                u.OwnerName,
                                u.ContactPersonName,
                                u.Adress,
                                u.PinCode,
                                u.PhoneNumber,
                                u.WhatsAppNumber,
                                u.Landmark,
                                u.Image,
                                u.CreditBalance,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.BeatId == BeatId && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{AgentId}")]
        public ActionResult GetStoreListbyAgentId(int AgentId)
        {
            try
            {
                var list = (from u in _context.Stores
                            join b in _context.Agents on u.CreatedBy equals b.AgentId
                            join a in _context.Users on b.CreatedBy equals a.UserId
                            

                            select new
                            {
                                u.StoreId,
                                a.UserId,
                                a.UserName,
                                b.AgentId,
                                b.AgentName,
                                u.StoreName,
                                u.OwnerName,
                                u.ContactPersonName,
                                u.Adress,
                                u.PinCode,
                                u.PhoneNumber,
                                u.WhatsAppNumber,
                                u.Landmark,
                                u.Image,
                                u.CreditBalance,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.AgentId == AgentId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{StoreId}")]
        public ActionResult GetSingleStore(int StoreId)
        {
            try
            {
                var singleStore = _StoreRepo.SelectById(StoreId);
                return Ok(singleStore);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult UpdateStore(UpdateStoreDTO updateStoreDTO)
        {
            try
            {
                var objStore = _context.Stores.SingleOrDefault(opt => opt.StoreId == updateStoreDTO.StoreId);
                objStore.StoreName = updateStoreDTO.StoreName;
                objStore.BeatId = updateStoreDTO.BeatId;
                objStore.OwnerName = updateStoreDTO.OwnerName;
                objStore.ContactPersonName = updateStoreDTO.ContactPersonName;
                objStore.Adress = updateStoreDTO.Adress;
                objStore.PinCode = updateStoreDTO.PinCode;
                objStore.PhoneNumber = updateStoreDTO.PhoneNumber;
                objStore.WhatsAppNumber = updateStoreDTO.WhatsAppNumber;
                objStore.Landmark = updateStoreDTO.Landmark;
                objStore.Image = updateStoreDTO.Image;
                objStore.CreditBalance = updateStoreDTO.CreditBalance;
                objStore.UpdatedBy = updateStoreDTO.CreatedBy;
                objStore.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objStore);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteStore(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Stores.SingleOrDefault(opt => opt.StoreId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
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
  