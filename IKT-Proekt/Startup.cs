using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IKT_Proekt.Startup))]
namespace IKT_Proekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
