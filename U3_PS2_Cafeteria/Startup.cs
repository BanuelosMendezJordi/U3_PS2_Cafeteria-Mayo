using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(U3_PS2_Cafeteria.Startup))]
namespace U3_PS2_Cafeteria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
