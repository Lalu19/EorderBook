using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AreaController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Area> _AreaRepo;

        public AreaController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<Area> areaRepo)
        {
            _config = config;
            _context = context;
            _AreaRepo = areaRepo;
        }
        [HttpPost]
        public IActionResult AreaRepoCreate(AreaDTO createAreaDTO)
        {
            try
            {
                Area area = new Area();
                area.AreaName = createAreaDTO.AreaName;
                area.CityId = createAreaDTO.CityId;
                area.AgentId = createAreaDTO.AgentId;
                area.CreatedBy = createAreaDTO.CreatedBy;
                area.CreatedOn = System.DateTime.Now;
                var obj = _AreaRepo.Insert(area);
                return Ok(obj);
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetAreaList()
        {
            try
            {
                var list = (from u in _context.Areas
                            join a in _context.Citys on u.CityId equals a.CityId
                            join b in _context.Agents on u.AgentId equals b.AgentId

                            select new { u.AreaId, u.AreaName, a.CityName, u.CityId, b.AgentId, b.AgentName, u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetAreaListByUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Areas
                            join a in _context.Citys on u.CityId equals a.CityId
                            join b in _context.Agents on u.AgentId equals b.AgentId

                            select new { u.AreaId, u.AreaName, a.CityName, u.CityId,b.AgentId,b.AgentName,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{AgentId}/{UserId}")]
        public ActionResult GetAreaListbyAgentId(int AgentId,int UserId)
        {
            try
            {
                var list = (from u in _context.Areas
                            join a in _context.Agents on u.AgentId equals a.AgentId

                            select new
                            {
                                u.AreaId,
                                u.AreaName,
                                a.AgentId,
                                a.AgentName,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.AgentId == AgentId && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{AreaId}")]
        public ActionResult GetSingleArea(int AreaId)
        {
            try
            {
                var singleArea = _AreaRepo.SelectById(AreaId);
                return Ok(singleArea);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateArea(AreaUpdateDTO updateAreaDTO)
        {
            try
            {
                var objarea = _context.Areas.SingleOrDefault(opt => opt.AreaId == updateAreaDTO.AreaId);
                objarea.AreaName = updateAreaDTO.AreaName;
                objarea.CityId = updateAreaDTO.CityId;
                objarea.AgentId = updateAreaDTO.AgentId;
                objarea.UpdatedBy = updateAreaDTO.UpdatedBy;
                objarea.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objarea);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteArea(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Areas.SingleOrDefault(opt => opt.AreaId == Id);
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

