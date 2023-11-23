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
using AdminApi.Models.App.ProductMaster;
using AdminApi.DTO.App.ProductMasterDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Category> _CategoryRepo;

        public CategoryController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<Category> categoryRepo)
        {
            _config = config;
            _context = context;
            _CategoryRepo = categoryRepo;
        }
        [HttpPost]
        public IActionResult CategoryRepoCreate(CreateCategoryDTO createCategoryDTO)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = createCategoryDTO.CategoryName;
                category.BrandId = createCategoryDTO.BrandId;
                category.CreatedBy = createCategoryDTO.CreatedBy;
                category.CreatedOn = System.DateTime.Now;
                var obj = _CategoryRepo.Insert(category);
                return Ok(obj);
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetCategoryList()
        {
            try
            {
                var list = (from u in _context.Categorys
                            join a in _context.Brands on u.BrandId equals a.BrandId

                            select new { u.CategoryId, u.CategoryName, a.BrandName, u.BrandId, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{UserId}")]
        public ActionResult GetCategoryListbyUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.Categorys
                            join a in _context.Brands on u.BrandId equals a.BrandId

                            select new { u.CategoryId, u.CategoryName, a.BrandName, u.BrandId,u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{BrandId}/{UserId}")]
        public ActionResult GetCategoryListbyBrandid(int BrandId , int UserId)
        {
            try
            {
                var list = (from u in _context.Categorys
                            join a in _context.Brands on u.BrandId equals a.BrandId

                            select new
                            {
                                u.CategoryId,
                                u.CategoryName,
                                a.BrandName,
                                u.BrandId,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.BrandId == BrandId && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{CategoryId}")]
        public ActionResult GetSingleCategory(int CategoryId)
        {
            try
            {
                var singleCategory = _CategoryRepo.SelectById(CategoryId);
                return Ok(singleCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            try
            {
                var objCategory = _context.Categorys.SingleOrDefault(opt => opt.CategoryId == updateCategoryDTO.CategoryId);
                objCategory.CategoryName = updateCategoryDTO.CategoryName;
                objCategory.BrandId = updateCategoryDTO.BrandId;
                objCategory.UpdatedBy = updateCategoryDTO.CreatedBy;
                objCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCategory(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Categorys.SingleOrDefault(opt => opt.CategoryId == Id);
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
