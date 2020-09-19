using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomHtmlHelpers.Startup))]
namespace CustomHtmlHelpers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
