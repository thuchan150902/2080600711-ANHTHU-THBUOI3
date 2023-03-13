using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080600711_ANHTHU_THBUOI3.Startup))]
namespace _2080600711_ANHTHU_THBUOI3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
