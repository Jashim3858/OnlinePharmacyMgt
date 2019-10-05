using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlinePharmacyManagement.Startup))]
namespace OnlinePharmacyManagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
