using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventByte.Startup))]
namespace EventByte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
