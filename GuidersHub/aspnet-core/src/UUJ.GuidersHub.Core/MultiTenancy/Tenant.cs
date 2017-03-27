using Abp.MultiTenancy;
using UUJ.GuidersHub.Authorization.Users;

namespace UUJ.GuidersHub.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}