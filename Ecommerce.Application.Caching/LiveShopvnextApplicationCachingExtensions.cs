using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Volo.Abp.Threading;

namespace Ecommerce.Application.Caching
{

    public static class LiveShopvnextApplicationCachingExtensions
    {
        private static readonly object obj = new object();
        /// <summary>
        /// 获取或添加缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache"></param>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public static async Task<T> GetOrAddAsync<T>(this IDistributedCache cache, string key, Func<Task<T>> factory, int minutes)
        {
            T cacheItem = default(T);

            var result = await cache.GetStringAsync(key);
            if (string.IsNullOrEmpty(result))
            {
                //解决缓存击穿问题，如果缓存过期，只让一个线程先去访问数据库取回数据，后面就不再需要去访问数据库
                lock (obj)
                {
                    //进线程后再查询一次缓存是否是空
                    result = AsyncHelper.RunSync(() => { return cache.GetStringAsync(key); });
                    if (string.IsNullOrEmpty(result))
                    {
                        //cacheItem = await factory.Invoke();
                        cacheItem = AsyncHelper.RunSync(() => { return factory.Invoke(); });

                        //设置有效期
                        var options = new DistributedCacheEntryOptions();
                        options.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(minutes);

                        //await cache.SetStringAsync(key, JsonConvert.SerializeObject(cacheItem), options);
                        //在线程同步lock中需要使用这种方式，用同步的方法来调用异步方法
                        AsyncHelper.RunSync(() => { return cache.SetStringAsync(key, JsonConvert.SerializeObject(cacheItem), options); });
                    }
                }
            }
            else
            {
                cacheItem = JsonConvert.DeserializeObject<T>(result);
            }

            return cacheItem;
        }
    }
}