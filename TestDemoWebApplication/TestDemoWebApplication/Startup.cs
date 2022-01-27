using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDemoWebApplication.Startup))]
namespace TestDemoWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
