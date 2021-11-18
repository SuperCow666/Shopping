using System.Threading.Tasks;

namespace Shopping.Data
{
    public interface IShoppingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
