using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStoreScaffolding.Startup))]
namespace MVCStoreScaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
