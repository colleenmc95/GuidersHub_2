using System.Reflection;
using Abp.Modules;
using UUJ.GuidersHub.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace UUJ.GuidersHub.Web.Host.Startup
{
    [DependsOn(
       typeof(GuidersHubWebCoreModule))]
    public class GuidersHubWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GuidersHubWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
