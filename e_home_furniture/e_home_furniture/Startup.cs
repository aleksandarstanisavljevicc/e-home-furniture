using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_home_furniture.Startup))]
namespace e_home_furniture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
