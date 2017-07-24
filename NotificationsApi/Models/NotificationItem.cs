using Microsoft.Azure.Mobile.Server;

namespace NotificationsApi.Models
{
    public class NotificationItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}