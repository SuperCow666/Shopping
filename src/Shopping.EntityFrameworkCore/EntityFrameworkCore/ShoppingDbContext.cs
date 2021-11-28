using Microsoft.EntityFrameworkCore;
using Shopping.Goods;
using Shopping.Sku;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Shopping.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class ShoppingDbContext :
        AbpDbContext<ShoppingDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */

        #region Entities from the modules

        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */

        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }

        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        #region Customer Entities
        
        #endregion
        #region Customer Entities
        public DbSet<GoodsType> goodsTypes { get; set; }
        public DbSet<brand> brand { get; set; }
        public DbSet<GoodsKind> GoodsKind { get; set; }
        public DbSet<commonGoods> commonGoods { get; set; }
        public DbSet<GeneralGoods> generalGoods { get; set; }
        public DbSet<GoodSKUValues> goodSKUValues { get; set; }
        public DbSet<tbCommodityInfo> tbCommodityInfos { get; set; }
        public DbSet<tbCommoditySpecifica>  tbCommoditySpecificas { get; set; }
        public DbSet<TbSaleNum> TbSaleNums { get; set; }
        public DbSet<mmall_attribute_key> mmall_attribute_keys { get; set; }

        public DbSet<mmall_attribute_value> mmall_attribute_values { get; set; }
        public DbSet<orderTable> orderTables { get; set; }
        public DbSet<OrderAttached> orderAttacheds { get; set; }

        public DbSet<taseKill> taseKills { get; set; }
        #endregion
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region Customer Entities
            builder.Entity<GoodsType>(b =>
            {
                b.ToTable("goodsTypes");
            }
            );
            builder.Entity<brand>(b =>
            {
                b.ToTable("brand");
            }
           );
            builder.Entity<commonGoods>(b =>
            {
                b.ToTable("commonGoods");
            }
           );
            builder.Entity<GoodsKind>(b =>
            {
                b.ToTable("GoodsKind");
            }
           );


            #endregion
            #region Customer Entities
            builder.Entity<GoodsType>(b =>
            {
                b.ToTable("goodsTypes");
            });
            #endregion
            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ShoppingConsts.DbTablePrefix + "YourEntities", ShoppingConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
