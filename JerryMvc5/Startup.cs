using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JerryMvc5.Startup))]
namespace JerryMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
