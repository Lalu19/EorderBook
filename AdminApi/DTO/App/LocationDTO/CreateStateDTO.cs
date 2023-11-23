namespace AdminApi.DTO.App.LocationDTO
{
    public class CreateStateDTO
    {
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateStateDTO
    {
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public int CreatedBy { get; set; }
    }
}
