namespace AdminApi.DTO.App.LocationDTO
{
    public class CountryDTO
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateCountryDTO
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CreatedBy { get; set; }
    }
}
