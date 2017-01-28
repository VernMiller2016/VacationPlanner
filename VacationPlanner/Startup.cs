using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VacationPlanner.Startup))]
namespace VacationPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
