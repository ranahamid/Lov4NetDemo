using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lov4NetV3.Startup))]
namespace Lov4NetV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }

    }
}
