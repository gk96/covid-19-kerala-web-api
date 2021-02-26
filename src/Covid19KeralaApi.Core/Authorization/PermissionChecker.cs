using Abp.Authorization;
using Covid19KeralaApi.Authorization.Roles;
using Covid19KeralaApi.Authorization.Users;

namespace Covid19KeralaApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
