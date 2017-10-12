using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCModelos3d.Startup))]
namespace MVCModelos3d
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
