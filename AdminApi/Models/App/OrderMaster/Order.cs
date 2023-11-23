using System;

namespace AdminApi.Models.App.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public string AutoOrderId { get; set; }
        public int StoreId { get; set; }
        public int AgentId { get; set; }
        public string Status { get; set; }
        public string TotalPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
