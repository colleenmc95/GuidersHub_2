using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace UUJ.GuidersHub.EntityFramework
{
    [DependsOn(
        typeof(GuidersHubCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class GuidersHubEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<GuidersHubDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}