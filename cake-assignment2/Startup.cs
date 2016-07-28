using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cake_assignment2.Startup))]
namespace cake_assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
