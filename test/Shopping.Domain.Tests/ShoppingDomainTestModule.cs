using Shopping.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Shopping
{
    [DependsOn(
        typeof(ShoppingEntityFrameworkCoreTestModule)
        )]
    public class ShoppingDomainTestModule : AbpModule
    {

    }
}