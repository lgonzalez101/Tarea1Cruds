using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea1Cruds_LuisGonzalez.Startup))]
namespace Tarea1Cruds_LuisGonzalez
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
