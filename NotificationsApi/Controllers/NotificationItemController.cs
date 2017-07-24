using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Config;
using Microsoft.Azure.NotificationHubs;
using NotificationsApi.Models;

namespace NotificationsApi.Controllers
{
    public class NotificationItemController : TableController<NotificationItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<NotificationItem>(context, Request);
        }

        // GET tables/NotificationItem
        public IQueryable<NotificationItem> GetAllNotificationItems()
        {
            return Query();
        }

        // GET tables/NotificationItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<NotificationItem> GetNotificationItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/NotificationItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<NotificationItem> PatchNotificationItem(string id, Delta<NotificationItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/NotificationItem
        public async Task<IHttpActionResult> PostNotificationItem(NotificationItem item)
        {
            NotificationItem current = await InsertAsync(item);

            // Get the settings for the server project.
            HttpConfiguration config = this.Configuration;
            MobileAppSettingsDictionary settings = this.Configuration.GetMobileAppSettingsProvider().GetMobileAppSettings();

            // Get the Notification Hubs credentials for the Mobile App.
            string notificationHubName = settings.NotificationHubName;
            string notificationHubConnection = settings.Connections[MobileAppSettingsKeys.NotificationHubConnectionString].ConnectionString;

            // Create a new Notification Hub client.
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(notificationHubConnection, notificationHubName);

            // iOS payload
            var appleNotificationPayload = "{\"aps\":{\"alert\":\"" + item.Text + "\"}}";

            try
            {
                // Send the push notification and log the results.
                var result = await hub.SendAppleNativeNotificationAsync(appleNotificationPayload);

                // Write the success result to the logs.
                config.Services.GetTraceWriter().Info(result.State.ToString());
            }
            catch (System.Exception ex)
            {
                // Write the failure result to the logs.
                config.Services.GetTraceWriter().Error(ex.Message, null, "Push.SendAsync Error");
            }
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/NotificationItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteNotificationItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}