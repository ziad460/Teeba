using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teeba.Startup))]
namespace Teeba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
