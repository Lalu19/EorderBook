using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using AdminApi.Models.App.ProductMaster;
using AdminApi.Models.App.BeatMaster;
using AdminApi.DTO.App.BeatMasterDTO;
using AdminApi.DTO.App.ProductMasterDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Brand> _BrandRepo;
        public BrandController(IConfiguration config,
                                   AppDbContext context,
                                   ISqlRepository<Brand> brandRepo)
        {
            _config = config;
            _context = context;
            _BrandRepo = brandRepo;
        }

        [HttpPost]
        public IActionResult BrandRepoCreate(CreateBrandDTO createBrandDTO)
        {
            var objcheck = _context.Brands.SingleOrDefault(opt => opt.BrandName == createBrandDTO.BrandName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Brand brand = new Brand();
                    brand.BrandName = createBrandDTO.BrandName;
                    brand.CreatedBy = createBrandDTO.CreatedBy;
                    brand.CreatedOn = System.DateTime.Now;
                    var obj = _BrandRepo.Insert(brand);
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
        public ActionResult GetBrandList()
        {
            try
            {
                var list = (from u in _context.Brands

                            select new { u.BrandId, u.BrandName,  u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetBrandListbyUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Brands

                            select new { u.BrandId, u.BrandName,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{BrandId}")]
        public ActionResult GetSingleBrand(int BrandId)
        {
            try
            {
                var singleBrand = _BrandRepo.SelectById(BrandId);
                return Ok(singleBrand);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateBrand(UpdateBrandDTO updateBrandDTO)
        {
            try
            {
                var objBrand = _context.Brands.SingleOrDefault(opt => opt.BrandId == updateBrandDTO.BrandId);
                objBrand.BrandName = updateBrandDTO.BrandName;
                objBrand.UpdatedBy = updateBrandDTO.CreatedBy;
                objBrand.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objBrand);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteBrand(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Brands.SingleOrDefault(opt => opt.BrandId == Id);
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
