using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrawlerNet.Startup))]
namespace CrawlerNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
