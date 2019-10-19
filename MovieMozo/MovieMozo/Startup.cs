using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieMozo.Startup))]
namespace MovieMozo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
