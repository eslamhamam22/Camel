using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CamelSystem.Controllers
{
    public abstract class CamelSystemControllerBase: AbpController
    {
        protected CamelSystemControllerBase()
        {
            LocalizationSourceName = CamelSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
