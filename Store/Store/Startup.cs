using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store.Startup))]
namespace Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
