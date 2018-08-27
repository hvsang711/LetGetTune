using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetGetTune.Startup))]
namespace LetGetTune
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
