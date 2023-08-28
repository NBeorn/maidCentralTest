using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace maidCentralTest.Controllers
{
    public abstract class maidCentralTestControllerBase: AbpController
    {
        protected maidCentralTestControllerBase()
        {
            LocalizationSourceName = maidCentralTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
