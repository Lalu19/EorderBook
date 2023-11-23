namespace AdminApi.DTO.App.AddtoCartDTO
{
    public class AddtoCartDTO
    {
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
    }
}
