namespace AdminApi.DTO.App.LocationDTO
{
    public class CreateAreaDTO
    {
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
    }

   public interface UpdateAreaDTO
    {
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
    }
}
