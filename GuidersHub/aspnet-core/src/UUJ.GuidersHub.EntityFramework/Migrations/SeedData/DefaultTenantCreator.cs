using System.Linq;
using UUJ.GuidersHub.EntityFramework;
using UUJ.GuidersHub.MultiTenancy;

namespace UUJ.GuidersHub.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly GuidersHubDbContext _context;

        public DefaultTenantCreator(GuidersHubDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
