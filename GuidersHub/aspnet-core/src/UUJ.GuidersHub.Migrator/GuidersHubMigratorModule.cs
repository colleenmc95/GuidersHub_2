using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using UUJ.GuidersHub.Configuration;
using UUJ.GuidersHub.EntityFramework;

namespace UUJ.GuidersHub.Migrator
{
    [DependsOn(typeof(GuidersHubEntityFrameworkModule))]
    public class GuidersHubMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GuidersHubMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(GuidersHubMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<GuidersHubDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GuidersHubConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}