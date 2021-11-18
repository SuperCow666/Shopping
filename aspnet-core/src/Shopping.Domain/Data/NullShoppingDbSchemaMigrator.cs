using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Shopping.Data
{
    /* This is used if database provider does't define
     * IShoppingDbSchemaMigrator implementation.
     */
    public class NullShoppingDbSchemaMigrator : IShoppingDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}