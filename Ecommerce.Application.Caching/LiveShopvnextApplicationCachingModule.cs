using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Ecommerce.Application.Caching
{
    public class LiveShopvnextApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //从appsetting.json里取数据库连接
            var configuration = context.Services.GetConfiguration();
            var RedisConnectionString = configuration["Caching:RedisConnectionString"];
            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = RedisConnectionString;
            });
            //需引用包Nuget包  caching.csredis
            var csredis = new CSRedis.CSRedisClient(RedisConnectionString);
            RedisHelper.Initialization(csredis);

            context.Services.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
        }
    }

}