using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tour_and_Guide_to_GilgitBaltistan.Startup))]
namespace Tour_and_Guide_to_GilgitBaltistan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
