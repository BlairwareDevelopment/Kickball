using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kickball.Startup))]
namespace Kickball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
