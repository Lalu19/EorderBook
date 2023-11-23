namespace AdminApi.DTO.App.ProductMasterDTO
{
    public class CreateProductDetailsDTO
    {
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductDetailsName { get; set; }
        public string image { get; set; }
        public string MRP { get; set; }
        public string SellingPrice { get; set; }
        public string PackagingType { get; set; }
        //public string TotalStock { get; set; }
        public string Quantity { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateProductDetailsDTO
    {
        public int ProductDetailsId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductDetailsName { get; set; }
        public string image { get; set; }
        public string MRP { get; set; }
        public string SellingPrice { get; set; }
        public string PackagingType { get; set; }
        //public string TotalStock { get; set; }
        public string Quantity { get; set; }
        public int CreatedBy { get; set; }
    }
}
