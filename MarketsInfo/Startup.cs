using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketsInfo.Startup))]
namespace MarketsInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
