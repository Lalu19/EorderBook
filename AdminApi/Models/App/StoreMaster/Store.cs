using System;

namespace AdminApi.Models.App.StoreMaster
{
    public class Store
    {
        
        public int StoreId { get; set; }
        public int AgentId { get; set; }
        public int BeatId { get; set; }
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string ContactPersonName {get; set; }
        public string Adress { get; set; }
        public string PinCode { get; set; }
        public string PhoneNumber { get; set; } 
        public string WhatsAppNumber { get; set; }
        public string Landmark { get; set; }
        public string Image { get; set; }
        public string CreditBalance { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
