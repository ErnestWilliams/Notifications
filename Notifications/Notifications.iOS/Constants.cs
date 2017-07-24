using System;
namespace Notifications.iOS
{
    public class Constants
    {
        public Constants()
        {
        }
		// Azure app-specific connection string and hub path
		public const string ConnectionString = "Endpoint=sb://ns-test.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=Y45N8z+L4mj4f+dDWPgERyP2H7+PuUqDW6Y3LQUWSoE=";
		public const string NotificationHubPath = "Hub_Test";
    }
}
