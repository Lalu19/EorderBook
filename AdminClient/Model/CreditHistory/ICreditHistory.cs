using AdminClient.DTO;

namespace AdminClient.Model.CreditHistory
{
    public interface ICreditHistory
    {
        public MobileUploadViewModel CreateTransaction(CreditHistoryNewDTO creditHistoryNewDTO);
    }
}
