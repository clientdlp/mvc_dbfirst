using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoSite1.Startup))]
namespace ContosoSite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
