using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WijMoFlexGridCalendar.Startup))]
namespace WijMoFlexGridCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
