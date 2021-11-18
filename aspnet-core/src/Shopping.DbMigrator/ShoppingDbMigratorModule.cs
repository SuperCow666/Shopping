using Shopping.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Shopping.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ShoppingEntityFrameworkCoreModule),
        typeof(ShoppingApplicationContractsModule)
        )]
    public class ShoppingDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
