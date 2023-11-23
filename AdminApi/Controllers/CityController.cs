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
    public class CityController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<City> _CityRepo;

        public CityController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<City> cityRepo)
        {
            _config = config;
            _context = context;
            _CityRepo = cityRepo;
        }
        [HttpPost]
        public IActionResult CityRepoCreate(CreateCityDTO createCityDTO)
        {
            try
            {
                City city = new City();
                city.CityName = createCityDTO.CityName;
                city.DistrictId = createCityDTO.DistrictId;
                city.CreatedBy = createCityDTO.CreatedBy;
                city.CreatedOn = System.DateTime.Now;
                var obj = _CityRepo.Insert(city);
                return Ok(obj);

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetCityList()
        {
            try
            {
                var list = (from u in _context.Citys
                            join a in _context.Districts on u.DistrictId equals a.DistrictId

                            select new { u.CityId, u.CityName, a.DistrictName, u.DistrictId, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetCityListByUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Citys
                            join a in _context.Districts on u.DistrictId equals a.DistrictId

                            select new { u.CityId, u.CityName, a.DistrictName, u.DistrictId,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{CityId}")]
        public ActionResult GetSingleCity(int CityId)
        {
            try
            {
                var singleCity = _CityRepo.SelectById(CityId);
                return Ok(singleCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateCity(UpdateCityDTO updateCityDTO)
        {
            try
            {
                var objCity = _context.Citys.SingleOrDefault(opt => opt.CityId == updateCityDTO.CityId);
                objCity.CityName = updateCityDTO.CityName;
                objCity.DistrictId = updateCityDTO.DistrictId;
                objCity.UpdatedBy = updateCityDTO.CreatedBy;
                objCity.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCity(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Citys.SingleOrDefault(opt => opt.CityId == Id);
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
