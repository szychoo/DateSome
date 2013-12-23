using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DateSome.Startup))]
namespace DateSome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
