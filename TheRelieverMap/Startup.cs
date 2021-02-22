using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheRelieverMap.Startup))]
namespace TheRelieverMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
