namespace AdminApi.DTO.App.ProductMasterDTO
{
    public class CreateCategoryDTO
    {
        public int BrandId { get; set; }
        public string CategoryName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateCategoryDTO
    {
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string CategoryName { get; set; }
        public int CreatedBy { get; set; }
    }
}
