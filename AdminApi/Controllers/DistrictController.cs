using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Location;
using AdminApi.DTO.App.LocationDTO;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DistrictController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<District> _DistrictRepo;

        public DistrictController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<District> districtRepo)
        {
            _config = config;
            _context = context;
            _DistrictRepo = districtRepo;
        }
        [HttpPost]
        public IActionResult DistrictRepoCreate(CreateDistrictDTO createDistrictDTO)
        {
            try
            {
                District district = new District();
                district.DistrictName = createDistrictDTO.DistrictName;
                district.StateId = createDistrictDTO.StateId;
                district.CreatedBy = createDistrictDTO.CreatedBy;
                district.CreatedOn = System.DateTime.Now;
                var obj = _DistrictRepo.Insert(district);
                return Ok(obj);

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetDistrictList()
        {
            try
            {
                var list = (from u in _context.Districts
                            join a in _context.States on u.StateId equals a.StateId

                            select new { u.DistrictId, u.DistrictName, a.StateName, u.StateId, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetDistrictListGetUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Districts
                            join a in _context.States on u.StateId equals a.StateId

                            select new { u.DistrictId, u.DistrictName, a.StateName, u.StateId,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId ).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{DistrictId}")]
        public ActionResult GetSingleDistrict(int DistrictId)
        {
            try
            {
                var singleDistrict = _DistrictRepo.SelectById(DistrictId);
                return Ok(singleDistrict);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateDistrict(UpdateDistrictDTO updateDistrictDTO)
        {
            try
            {
                var objDistrict = _context.Districts.SingleOrDefault(opt => opt.DistrictId == updateDistrictDTO.DistrictId);
                objDistrict.DistrictName = updateDistrictDTO.DistrictName;
                objDistrict.StateId = updateDistrictDTO.StateId;
                objDistrict.UpdatedBy = updateDistrictDTO.CreatedBy;
                objDistrict.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objDistrict);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteDistrict(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Districts.SingleOrDefault(opt => opt.DistrictId == Id);
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

