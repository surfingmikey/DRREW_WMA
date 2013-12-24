using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WMA_MVC5.Startup))]
namespace WMA_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
