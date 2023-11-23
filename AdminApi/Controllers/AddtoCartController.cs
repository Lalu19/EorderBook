using AdminApi.DTO.App.StoreMasterDTO;
using AdminApi.Models.App.StoreMaster;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App.Agent;
using AdminApi.DTO.App.AgentDTO;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Security.Cryptography;
using AdminApi.Models.App.AddtoCart;
using AdminApi.DTO.App.AddtoCartDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddtoCartController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<AddtoCart> _AddtocartRepo;
        public AddtoCartController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<AddtoCart> AddtocartRepo)

        {
            _config = config;
            _context = context;
            _AddtocartRepo = AddtocartRepo;

        }
        [HttpPost]
        public IActionResult CreateAddToCart(AddtoCartDTO addtoCartDTO)
        {
            var objCheck = _context.AddtoCart.SingleOrDefault(opt => opt.ProductDetailsId == addtoCartDTO.ProductDetailsId && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    AddtoCart addtoCart = new AddtoCart();
                    addtoCart.BrandId = addtoCartDTO.BrandId;
                    addtoCart.CategoryId = addtoCartDTO.CategoryId;
                    addtoCart.ProductDetailsId = addtoCartDTO.ProductDetailsId;
                    addtoCart.PackagingType = addtoCartDTO.PackagingType;
                    addtoCart.Quantity = addtoCartDTO.Quantity;
                    addtoCart.Mrp = addtoCartDTO.Mrp;
                    addtoCart.SellingPrice = addtoCartDTO.SellingPrice;
                    addtoCart.AgentId = addtoCartDTO.AgentId;
                    addtoCart.StoreId=addtoCartDTO.StoreId;
                    addtoCart.CreatedBy = addtoCartDTO.CreatedBy;
                    var obj = _AddtocartRepo.Insert(addtoCart);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Product..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{AgentId}/{UserId}")]
        public ActionResult GetAddtoCartListByAgentIdandUserId(int AgentId,int UserId)
        {
            try
            {
                var list = (from u in _context.AddtoCart
                            join a in _context.Brands on
                            u.BrandId equals a.BrandId
                            join b in _context.Categorys on
                            u.CategoryId equals b.CategoryId
                            join c in _context.ProductDetailss on
                            u.ProductDetailsId equals c.ProductDetailsId

                            select new
                            {
                                u.AddtoCartId,
                                u.BrandId,
                                a.BrandName,
                                u.CategoryId,
                                b.CategoryName,
                                u.ProductDetailsId,
                                c.ProductDetailsName,
                                c.image,
                                c.MRP,
                                c.SellingPrice,
                                u.IsDeleted,
                                u.AgentId,
                                u.CreatedBy

                            }).Where(x => x.IsDeleted == false && x.CreatedBy == AgentId && x.AgentId==AgentId);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteAddtoCart(int Id, int DeletedBy)
        {
            try
            {
                var objAddtoCart = _context.AddtoCart.SingleOrDefault(opt => opt.AddtoCartId == Id);
                objAddtoCart.IsDeleted = true;
                objAddtoCart.UpdatedBy = DeletedBy;
                objAddtoCart.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objAddtoCart);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}")]
        public ActionResult RemoveAddtoCart(int Id)
        {
            try
            {
                var objAddtoCart = _context.AddtoCart.SingleOrDefault(opt => opt.AddtoCartId == Id);
                objAddtoCart.IsDeleted = true;
                objAddtoCart.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objAddtoCart);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
