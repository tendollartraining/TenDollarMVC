using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Michaels_Stuff.Startup))]
namespace Michaels_Stuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
