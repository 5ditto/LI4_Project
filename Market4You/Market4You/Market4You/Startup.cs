using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Market4You.Startup))]
namespace Market4You
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
