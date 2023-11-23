using System;

namespace AdminApi.Models.App.StoreNotification
{
    public class StoreNotification
    {
        public int StoreNotificationId { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string StoreImage { get; set; }
        public int AgentId { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
