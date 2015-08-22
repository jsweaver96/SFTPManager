using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SFTPManager.Startup))]
namespace SFTPManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
