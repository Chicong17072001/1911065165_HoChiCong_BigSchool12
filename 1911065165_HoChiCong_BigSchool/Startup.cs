using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065165_HoChiCong_BigSchool.Startup))]
namespace _1911065165_HoChiCong_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
