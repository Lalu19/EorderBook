using System;

namespace AdminApi.Models.App.BeatMaster
{
    public class Beat
    {
        public int BeatId { get; set; }
        public int AreaId { get; set; }
        public string BeatName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
