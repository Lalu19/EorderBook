namespace AdminApi.DTO.App.ProductMasterDTO
{
    public class CreateBrandDTO
    {
        public string BrandName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateBrandDTO
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CreatedBy { get; set; }
    }
}
