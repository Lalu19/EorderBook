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

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeatController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Beat> _BeatRepo;

        public BeatController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<Beat> beatRepo)
        {
            _config = config;
            _context = context;
            _BeatRepo = beatRepo;
        }
        [HttpPost]
        public IActionResult BeatRepoCreate(CreateBeatDTO createBeatDTO)
        {
            try
            {
                Beat beat = new Beat();
                beat.BeatName = createBeatDTO.BeatName;
                beat.AreaId = createBeatDTO.AreaId;
                beat.CreatedBy = createBeatDTO.CreatedBy;
                beat.CreatedOn = System.DateTime.Now;
                var obj = _BeatRepo.Insert(beat);
                return Ok(obj);

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetBeatList()
        {
            try
            {
                var list = (from u in _context.Beats
                            join a in _context.Areas on u.AreaId equals a.AreaId

                            select new { u.BeatId, u.BeatName, a.AreaName, u.AreaId, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetBeatListbyUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Beats
                            join a in _context.Areas on u.AreaId equals a.AreaId

                            select new { u.BeatId, u.BeatName, a.AreaName, u.AreaId,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpGet("{AreaId}/{UserId}")]
        public ActionResult GetBeatListbyareaid(int AreaId,int UserId)
        {
            try
            {
                var list = (from u in _context.Beats
                            join a in _context.Areas on u.AreaId equals a.AreaId

                            select new { 
                                u.BeatId, 
                                u.BeatName, 
                                a.AreaName, 
                                u.AreaId, 
                                u.CreatedBy,
                                u.IsDeleted }).Where(x => x.IsDeleted == false && x.AreaId == AreaId && x.CreatedBy==UserId ).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{BeatId}")]
        public ActionResult GetSingleBeat(int BeatId)
        {
            try
            {
                var singleBeat = _BeatRepo.SelectById(BeatId);
                return Ok(singleBeat);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        
        //update
        [HttpPost]
        public ActionResult updateBeat(UpdateBeatDTO updateBeatDTO)
        {
            try
            {
                var objBeat = _context.Beats.SingleOrDefault(opt => opt.BeatId == updateBeatDTO.BeatId);
                objBeat.BeatName = updateBeatDTO.BeatName;
                objBeat.AreaId = updateBeatDTO.AreaId;
                objBeat.UpdatedBy = updateBeatDTO.CreatedBy;
                objBeat.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objBeat);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteBeat(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Beats.SingleOrDefault(opt => opt.BeatId == Id);
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
