using System.Data.Common;
using System.Data.Entity;
using Abp.Notifications;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using UUJ.GuidersHub.Authorization.Roles;
using UUJ.GuidersHub.Authorization.Users;
using UUJ.GuidersHub.Configuration;
using UUJ.GuidersHub.MultiTenancy;
using UUJ.GuidersHub.Web;
using UUJ.GuidersHub.Events;

namespace UUJ.GuidersHub.EntityFramework
{
    [DbConfigurationType(typeof(GuidersHubDbConfiguration))]
    public class GuidersHubDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */
        public DbSet<Event> Event { get; set; }

        /* Default constructor is needed for EF command line tool. */
        public GuidersHubDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                GuidersHubConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of GuidersHubDbContext since ABP automatically handles it.
         */
        public GuidersHubDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public GuidersHubDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public GuidersHubDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class GuidersHubDbConfiguration : DbConfiguration
    {
        public GuidersHubDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
