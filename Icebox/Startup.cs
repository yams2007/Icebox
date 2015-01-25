using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Icebox.Startup))]
namespace Icebox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
