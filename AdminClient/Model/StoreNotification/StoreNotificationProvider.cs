using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Model.StoreNotification
{
    public class StoreNotificationProvider:IStoreNotification
    {
        IHttpWebClients _objIHttpWebClients;
        public StoreNotificationProvider(IHttpWebClients objIHttpWebClients)
        {
            _objIHttpWebClients = objIHttpWebClients;
        }

        public StoreNotificationViewModel CreateNotification(StoreNotificationNewDTO storeNotificationNewDTO)
        {
            try
            {
                StoreNotificationViewModel objupdateResults = new StoreNotificationViewModel();
                objupdateResults = JsonConvert.DeserializeObject<StoreNotificationViewModel>(_objIHttpWebClients.PostRequest("/api/StoreNotification/CreateNotification", JsonConvert.SerializeObject(storeNotificationNewDTO), true));
                return objupdateResults;
            }
            catch (Exception)
            {
                throw;

            }
        }

       
    }
}
