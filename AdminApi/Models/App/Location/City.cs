using System;

namespace AdminApi.Models.App.Location
{
    public class City
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
