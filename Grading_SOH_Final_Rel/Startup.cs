using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grading_SOH_Final_Rel.Startup))]
namespace Grading_SOH_Final_Rel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
