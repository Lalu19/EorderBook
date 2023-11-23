using System;

namespace AdminApi.Models.App.AddtoCart
{
    public class AddtoCart
    {
        public int AddtoCartId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ProductDetailsId { get; set; }
        public string PackagingType { get; set; }
        public string Quantity { get; set; }
        public string Mrp { get; set; }
        public string SellingPrice { get; set; }
        public int StoreId { get; set; }
        public int AgentId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
