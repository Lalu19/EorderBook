using System;

namespace AdminApi.Models.App.UserAsign
{
    public class UserAssign
    {
        public int UserAssignId {get; set;}
        public int CityId { get; set;}
        public int AreaId { get; set;}
        public int BeatId { get; set;}
        public int BeatCoadId { get; set;}
        public DateTime AssignDate { get; set;}
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
