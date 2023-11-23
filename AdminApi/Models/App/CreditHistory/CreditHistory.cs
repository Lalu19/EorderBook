using System;

namespace AdminApi.Models.App.CreditHistory
{
    public class CreditHistory
    {
        public int CreditHistoryId { get; set; }
        public int StoreId { get; set; }
        public string CreditBalance { get; set; }
        public string DebitBalance { get; set; }
        public string TransactionID { get; set; }
        public string TotalOutstanding { get; set; }
        public string TransactionStatus { get; set; }
        public string Receipt { get; set; }
        public int AgentId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
