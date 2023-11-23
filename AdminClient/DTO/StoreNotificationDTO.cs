using Microsoft.AspNetCore.Http;

namespace AdminClient.DTO
{
    public class StoreNotificationDTO
    {
        public string Status { get; set; }
        public string Remark { get; set; }
        public string StoreImage { get; set; }
        public int AgentId { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
        public IFormFile file { get; set; }
    }
    public class StoreNotificationViewModel
    {
        public int StoreNotificationId { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string StoreImage { get; set; }
        public int AgentId { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class StoreNotificationNewDTO
    {
        public string Status { get; set; }
        public string Remark { get; set; }
        public string StoreImage { get; set; }
        public int AgentId { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
    }
}
