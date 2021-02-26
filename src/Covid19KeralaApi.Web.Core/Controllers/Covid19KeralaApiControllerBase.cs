using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Covid19KeralaApi.Controllers
{
    public abstract class Covid19KeralaApiControllerBase: AbpController
    {
        protected Covid19KeralaApiControllerBase()
        {
            LocalizationSourceName = Covid19KeralaApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
