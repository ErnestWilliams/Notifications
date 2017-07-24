using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NotificationsApi.Startup))]

namespace NotificationsApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}