using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Technical_Prototype.Startup))]
namespace Technical_Prototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
