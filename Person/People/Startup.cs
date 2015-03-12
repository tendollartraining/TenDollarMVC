using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(People.Startup))]
namespace People
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
