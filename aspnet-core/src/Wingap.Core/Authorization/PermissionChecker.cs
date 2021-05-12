using Abp.Authorization;
using Wingap.Authorization.Roles;
using Wingap.Authorization.Users;

namespace Wingap.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
