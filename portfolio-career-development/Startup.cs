using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio_career_development.Startup))]
namespace portfolio_career_development
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
