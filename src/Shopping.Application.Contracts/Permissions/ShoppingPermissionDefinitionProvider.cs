using Shopping.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Shopping.Permissions
{
    public class ShoppingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ShoppingPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ShoppingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ShoppingResource>(name);
        }
    }
}
