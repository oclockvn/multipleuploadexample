using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleUploadFileExample.Startup))]
namespace MultipleUploadFileExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
