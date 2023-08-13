using Abp.Authorization;
using CamelSystem.Authorization.Roles;
using CamelSystem.Authorization.Users;

namespace CamelSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
