using System;

namespace AdminApi.Models.App.ProductMaster
{
    public class ProductDetails
    {
        public int ProductDetailsId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductDetailsName { get; set; }
        public string image { get; set; }
        public string MRP { get; set; }
        public string SellingPrice { get; set; }
        public string PackagingType {get; set; }
        public string Quantity { get; set; }
        public string ProductStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
