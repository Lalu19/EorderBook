using System;

namespace AdminApi.Models.App.Location
{ 
    public class District
    {
        public int StateId { get; set; }
        public int DistrictId {get; set; }
        public string DistrictName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}

