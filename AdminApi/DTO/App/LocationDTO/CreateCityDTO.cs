namespace AdminApi.DTO.App.LocationDTO
{
    public class CreateCityDTO
    {
        public int DistrictId { get; set; }
        public string CityName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateCityDTO
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CreatedBy { get; set; }
    }
}
