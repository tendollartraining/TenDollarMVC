using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyDB.Startup))]
namespace FamilyDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
