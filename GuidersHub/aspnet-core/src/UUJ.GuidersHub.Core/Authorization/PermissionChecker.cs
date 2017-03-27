using Abp.Authorization;
using UUJ.GuidersHub.Authorization.Roles;
using UUJ.GuidersHub.Authorization.Users;
using UUJ.GuidersHub.MultiTenancy;

namespace UUJ.GuidersHub.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
