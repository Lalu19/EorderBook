using AdminClient.DTO;

namespace AdminClient.Model.StoreNotification
{
    public interface IStoreNotification
    {
        public StoreNotificationViewModel CreateNotification(StoreNotificationNewDTO storeNotificationNewDTO);
    }
}
