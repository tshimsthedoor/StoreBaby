using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreBaby.Startup))]
namespace StoreBaby
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
