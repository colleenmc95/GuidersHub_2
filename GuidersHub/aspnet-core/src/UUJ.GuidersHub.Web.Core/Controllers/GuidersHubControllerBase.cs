using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNet.Identity;

namespace UUJ.GuidersHub.Controllers
{
    public abstract class GuidersHubControllerBase: AbpController
    {
        protected GuidersHubControllerBase()
        {
            LocalizationSourceName = GuidersHubConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}