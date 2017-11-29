using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CwActProject.Startup))]
namespace CwActProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
