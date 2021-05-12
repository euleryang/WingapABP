using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Wingap.Controllers
{
    public abstract class WingapControllerBase: AbpController
    {
        protected WingapControllerBase()
        {
            LocalizationSourceName = WingapConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
