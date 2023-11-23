using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Model.CreditHistory
{
    public class CreditHistoryProvider : ICreditHistory
    {
        IHttpWebClients _objIHttpWebClients;
        public CreditHistoryProvider(IHttpWebClients objIHttpWebClients)
        {
            _objIHttpWebClients = objIHttpWebClients;
        }

        public MobileUploadViewModel CreateTransaction(CreditHistoryNewDTO creditHistoryNewDTO)
        {
            try
            {
                MobileUploadViewModel objupdateResults = new MobileUploadViewModel();
                objupdateResults = JsonConvert.DeserializeObject<MobileUploadViewModel>(_objIHttpWebClients.PostRequest("/api/CreditHistory/TransactionCreate", JsonConvert.SerializeObject(creditHistoryNewDTO), true));
                return objupdateResults;
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
