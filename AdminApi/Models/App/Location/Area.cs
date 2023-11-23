using System;

namespace AdminApi.Models.App.Location
{
    public class Area
    {
        public int AreaId { get; set; }
        public int AgentId { get; set; }
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
