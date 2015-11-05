using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelephoneDirectory.Startup))]
namespace TelephoneDirectory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
