using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LpiCodeTest.Startup))]
namespace LpiCodeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
