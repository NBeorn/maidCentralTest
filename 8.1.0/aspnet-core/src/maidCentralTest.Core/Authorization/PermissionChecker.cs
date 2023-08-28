using Abp.Authorization;
using maidCentralTest.Authorization.Roles;
using maidCentralTest.Authorization.Users;

namespace maidCentralTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
