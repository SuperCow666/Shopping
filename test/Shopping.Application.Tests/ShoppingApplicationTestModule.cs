using Volo.Abp.Modularity;

namespace Shopping
{
    [DependsOn(
        typeof(ShoppingApplicationModule),
        typeof(ShoppingDomainTestModule)
        )]
    public class ShoppingApplicationTestModule : AbpModule
    {

    }
}