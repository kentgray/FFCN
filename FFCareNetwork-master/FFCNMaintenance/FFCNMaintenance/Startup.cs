using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FFCNMaintenance.Startup))]
namespace FFCNMaintenance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
