using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineCourt.Startup))]
namespace OnlineCourt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
