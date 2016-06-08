using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Structure_Helper.Startup))]
namespace Structure_Helper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
