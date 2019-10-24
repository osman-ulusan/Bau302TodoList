using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bau302TodoList.Startup))]
namespace Bau302TodoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
