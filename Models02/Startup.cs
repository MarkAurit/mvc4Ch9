using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Models02.Startup))]
namespace Models02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
