using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyChefTj.Startup))]
namespace DailyChefTj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
