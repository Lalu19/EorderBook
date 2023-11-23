using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Location;
using AdminApi.DTO.App.LocationDTO;
using System;
using System.Linq;
using AdminApi.Models.App.UserAsign;
using AdminApi.DTO.App.UserAssignDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserAssignController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<UserAssign> _UserAssignRepo;

        public UserAssignController(IConfiguration config,
                                   AppDbContext context,
                                   ISqlRepository<UserAssign> userAssignRepo)
        {
            _config = config;
            _context = context;
            _UserAssignRepo = userAssignRepo;
        }

        [HttpPost]
        public IActionResult UserAssignRepoCreate(UserAssignCreateDTO userAssignCreateDTO)
        {
            var objcheck = _context.UserAssigns.SingleOrDefault(opt => opt.CityId == userAssignCreateDTO.CityId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    UserAssign userAssign = new UserAssign();
                    userAssign.CityId = userAssignCreateDTO.CityId;
                    userAssign.AreaId = userAssignCreateDTO.AreaId;
                    userAssign.BeatId = userAssignCreateDTO.BeatId;
                    userAssign.BeatCoadId = userAssignCreateDTO.BeatCoadId;
                    userAssign.AssignDate = userAssignCreateDTO.AssignDate;
                    userAssign.CreatedBy = userAssignCreateDTO.CreatedBy;
                    userAssign.CreatedOn = System.DateTime.Now;
                    var obj = _UserAssignRepo.Insert(userAssign);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate StateName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetUserAssignList()
        {
            try
            {
                var list = (from u in _context.UserAssigns
                            join a in _context.Citys on u.CityId equals a.CityId
                            join b in _context.Areas on u.AreaId equals b.AreaId
                            join c in _context.Beats on u.BeatId equals c.BeatId

                            select new { 
                                        u.UserAssignId,
                                        u.CityId,
                                        a.CityName,
                                        u.AreaId,
                                        b.AreaName,
                                        u.BeatId,
                                        c.BeatName,
                                        u.BeatCoadId,
                                        u.AssignDate,
                                        u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet]
        public ActionResult GetSingleUserAssign(int UserAssignId)
        {
            try
            {
                var singleUserAssign = _UserAssignRepo.SelectById(UserAssignId);
                return Ok(singleUserAssign);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateUserAssign(UserAssignUpdateDTO userAssignUpdateDTO)
        {
            try
            {
                var objUserAssign = _context.UserAssigns.SingleOrDefault(opt => opt.UserAssignId == userAssignUpdateDTO.UserAssignId);
                objUserAssign.CityId = userAssignUpdateDTO.CityId;
                objUserAssign.AreaId = userAssignUpdateDTO.AreaId;
                objUserAssign.BeatId = userAssignUpdateDTO.BeatId;
                objUserAssign.AssignDate = userAssignUpdateDTO.AssignDate;
                objUserAssign.UpdatedBy = userAssignUpdateDTO.CreatedBy;
                objUserAssign.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objUserAssign);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult DeleteUserAssign(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.UserAssigns.SingleOrDefault(opt => opt.UserAssignId == Id);
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
