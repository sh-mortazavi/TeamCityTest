using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityAndAzureTest.Startup))]
namespace TeamCityAndAzureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
