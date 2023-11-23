namespace AdminApi.DTO.App.CreditHistoryDTO
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
    }
    public class CreditHistoryUpdateDTO
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
}
