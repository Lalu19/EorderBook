using System;
namespace AdminApi.DTO.App.StoreNotificationDTO
{
    public class StoreNotificationDTO
    {
        public string Status { get; set; }
        public string Remark { get; set; }
        public string StoreImage { get; set; }
        public int AgentId { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
    }
}
