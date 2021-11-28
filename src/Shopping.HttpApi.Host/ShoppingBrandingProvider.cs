using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Shopping
{
    [Dependency(ReplaceServices = true)]
    public class ShoppingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Shopping";
    }
}
