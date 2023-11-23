namespace AdminApi.DTO.App.LocationDTO
{
    public class AreaDTO
    {
        public int CityId { get; set; }
        public int AgentId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class AreaUpdateDTO
    {
        public int AreaId { get; set; }
        public int AgentId { get; set; }
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
