using Microsoft.AspNetCore.Http;

namespace AdminClient.DTO
{
    public class CreditHistoryDTO
    {
        public int StoreId { get; set; }
        public string CreditBalance { get; set; }
        public string DebitBalance { get; set; }
        public string TotalOutstanding { get; set; }
        public string Receipt { get; set; }
        public int AgentId { get; set; }
        public int CreatedBy { get; set; }
        public IFormFile file { get; set; }
    }
    public class CreditHistoryViewModel
    {
        public int CreditHistoryId { get; set; }
        public int StoreId { get; set; }
        public string CreditBalance { get; set; }
        public string DebitBalance { get; set; }
        public string TotalOutstanding { get; set; }
        public string Receipt { get; set; }
        public int AgentId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class CreditHistoryNewDTO
    {
        public int StoreId { get; set; }
        public string CreditBalance { get; set; }
        public string DebitBalance { get; set; }
        public string TotalOutstanding { get; set; }
        public string Receipt { get; set; }
        public int AgentId { get; set; }
        public int CreatedBy { get; set; }
    }
}
