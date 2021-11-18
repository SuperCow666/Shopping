using Volo.Abp.Settings;

namespace Shopping.Settings
{
    public class ShoppingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ShoppingSettings.MySetting1));
        }
    }
}
