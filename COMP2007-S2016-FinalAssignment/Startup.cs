using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2007_S2016_FinalAssignment.Startup))]
namespace COMP2007_S2016_FinalAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
