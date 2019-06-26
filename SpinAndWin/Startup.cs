using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpinAndWin.Startup))]
namespace SpinAndWin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
