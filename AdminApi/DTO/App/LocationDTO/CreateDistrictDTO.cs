namespace AdminApi.DTO.App.LocationDTO
{
    public class CreateDistrictDTO
    {
        public int StateId { get; set; }
        public string DistrictName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateDistrictDTO
    {
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int CreatedBy { get; set; }
    }
}
