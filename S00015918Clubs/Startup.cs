using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00015918Clubs.Startup))]
namespace S00015918Clubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
