using System;

namespace AdminApi.Models.App.OrderMaster
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ProductDetailsId { get; set; }
        public string PackagingType { get; set; }
        public string Quantity { get; set; }
        public string OrderStatus { get; set; }
        public string Mrp { get; set; }
        public string SellingPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
