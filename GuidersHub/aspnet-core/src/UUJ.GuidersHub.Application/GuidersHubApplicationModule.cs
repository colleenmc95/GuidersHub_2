using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using UUJ.GuidersHub.Authorization;

namespace UUJ.GuidersHub
{
    [DependsOn(
        typeof(GuidersHubCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GuidersHubApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GuidersHubAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}