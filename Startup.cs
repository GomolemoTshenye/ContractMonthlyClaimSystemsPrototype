using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractMonthlyClaimSystemsPrototype.Startup))]
namespace ContractMonthlyClaimSystemsPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
