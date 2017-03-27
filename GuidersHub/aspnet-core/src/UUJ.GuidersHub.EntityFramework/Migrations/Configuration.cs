using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using UUJ.GuidersHub.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace UUJ.GuidersHub.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<GuidersHub.EntityFramework.GuidersHubDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GuidersHub";
        }

        protected override void Seed(GuidersHub.EntityFramework.GuidersHubDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
