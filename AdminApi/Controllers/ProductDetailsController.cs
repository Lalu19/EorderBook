using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using AdminApi.Models.App.BeatMaster;
using AdminApi.DTO.App.BeatMasterDTO;
using AdminApi.Models.Helper;
using AdminApi.Models.App.ProductMaster;
using AdminApi.DTO.App.ProductMasterDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductDetailsController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<ProductDetails> _ProductDetails;

        public ProductDetailsController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<ProductDetails> productDetailsRepo)
        {
            _config = config;
            _context = context;
            _ProductDetails = productDetailsRepo;
        }
        [HttpPost]
        public IActionResult ProductDetailsRepoCreate(CreateProductDetailsDTO createProductDetailsDTO)
        {
            
            try
            {
                ProductDetails productDetails = new ProductDetails();
                productDetails.ProductDetailsName = createProductDetailsDTO.ProductDetailsName;
                productDetails.CategoryId = createProductDetailsDTO.CategoryId;
                productDetails.BrandId = createProductDetailsDTO.BrandId;
                productDetails.image = createProductDetailsDTO.image;
                productDetails.MRP = createProductDetailsDTO.MRP;
                productDetails.SellingPrice = createProductDetailsDTO.SellingPrice;
                productDetails.PackagingType = createProductDetailsDTO.PackagingType;
                productDetails.ProductStatus = "Stock";
                productDetails.Quantity = createProductDetailsDTO.Quantity;
                productDetails.CreatedBy = createProductDetailsDTO.CreatedBy;
                productDetails.CreatedOn = System.DateTime.Now;
                var obj = _ProductDetails.Insert(productDetails);
                return Ok(obj);
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetProductDetailsList()
        {
            try
            {
                var list = (from u in _context.ProductDetailss
                           join x in _context.Categorys on u.CategoryId equals x.CategoryId
                           join b in _context.Brands on u.BrandId equals b.BrandId
                            select new { 
                                u.ProductDetailsName,
                                u.ProductDetailsId,
                                x.CategoryName,
                                u.CategoryId,
                                b.BrandName,
                                u.BrandId,
                                u.image,
                                u.MRP,
                                u.SellingPrice,
                                u.PackagingType,
                                u.Quantity,
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
        public ActionResult GetProductDetailsListbyUserId(int UserId)
        {
            try
            {
                var list = (from u in _context.ProductDetailss
                            join x in _context.Categorys on u.CategoryId equals x.CategoryId
                            join b in _context.Brands on u.BrandId equals b.BrandId
                            select new
                            {
                                u.ProductDetailsName,
                                u.ProductDetailsId,
                                x.CategoryName,
                                u.CategoryId,
                                b.BrandName,
                                u.BrandId,
                                u.image,
                                u.MRP,
                                u.SellingPrice,
                                u.PackagingType,
                                u.ProductStatus,
                                u.Quantity,
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

        [HttpGet("{CategoryId}/{UserId}")]
        public ActionResult GetProductNameByCategoryId(int CategoryId, int UserId)
        {
            try
            {
                var list = (from u in _context.ProductDetailss
                            join x in _context.Categorys on u.CategoryId equals x.CategoryId
                            join b in _context.Brands on u.BrandId equals b.BrandId
                            select new
                            {
                                u.ProductDetailsId,
                                u.CategoryId,
                                u.ProductDetailsName,
                                u.MRP,
                                u.SellingPrice,
                                u.PackagingType,
                                u.image,
                                u.ProductStatus,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.ProductStatus== "Stock" && x.CategoryId==CategoryId && x.CreatedBy==UserId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{ProductDetailsId}")]
        public ActionResult GetSingleProductDetails(int ProductDetailsId)
        {
            try
            {
                var singleProductDetailsId = _ProductDetails.SelectById(ProductDetailsId);
                return Ok(singleProductDetailsId);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateProductDetails(UpdateProductDetailsDTO updateProductDetailsDTO)
        {
            try
            {
                var objProductDetails = _context.ProductDetailss.SingleOrDefault(opt => opt.ProductDetailsId == updateProductDetailsDTO.ProductDetailsId);
                objProductDetails.ProductDetailsName = updateProductDetailsDTO.ProductDetailsName;
                objProductDetails.CategoryId = updateProductDetailsDTO.CategoryId;
                objProductDetails.BrandId = updateProductDetailsDTO.BrandId;
                objProductDetails.image = updateProductDetailsDTO.image;
                objProductDetails.MRP = updateProductDetailsDTO.MRP;
                objProductDetails.SellingPrice = updateProductDetailsDTO.SellingPrice;
                objProductDetails.PackagingType = updateProductDetailsDTO.PackagingType;
                objProductDetails.Quantity = updateProductDetailsDTO.Quantity;
                objProductDetails.UpdatedBy = updateProductDetailsDTO.CreatedBy;
                objProductDetails.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objProductDetails);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteProductDetails(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.ProductDetailss.SingleOrDefault(opt => opt.ProductDetailsId == Id);
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

        [HttpGet("{Id}")]
        public ActionResult ProductOutOfStock(int Id)
        {
            try
            {
                var objabout = _context.ProductDetailss.SingleOrDefault(opt => opt.ProductDetailsId == Id);
                objabout.ProductStatus = "OutOfStock";
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}")]
        public ActionResult ProductStock(int Id)
        {
            try
            {
                var objabout = _context.ProductDetailss.SingleOrDefault(opt => opt.ProductDetailsId == Id);
                objabout.ProductStatus = "Stock";
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
