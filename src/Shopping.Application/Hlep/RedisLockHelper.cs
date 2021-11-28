using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;
using Education;
using Shopping;
using Shopping.Goods;

namespace Education.Common
{
    public class RedisHelp
    {

        public static void SetHashEntry(taseKill product)
        {
            RedisClient client = new RedisClient("127.0.0.1", 6379, null, 2);
          
            //添加第一种方式
            client.SetEntryInHash($"product_{product.seckillName}", nameof(product.seckillName), product.seckillName.ToString());
            client.SetEntryInHash($"product_{product.productId}", nameof(product.productId), product.productId.ToString());
            client.SetEntryInHash($"product_{product.seckillSatae}", nameof(product.seckillSatae), product.seckillSatae.ToString());
            client.SetEntryInHash($"product_{product.seckillPrice}", nameof(product.seckillPrice), product.seckillPrice.ToString());
            client.SetEntryInHash($"product_{product.seckillSum}", nameof(product.seckillSum), product.seckillSum.ToString());
            //添加第二种方式  UserInfo 必须有Id属性
            // client.StoreAsHash<UserInfo>(product);

        }

        public static Dictionary<string, string> GetHashEntry(Guid skuId )
        {
            RedisClient client = new RedisClient("127.0.0.1", 6379, null, 2);
            string hashId = $"product_{skuId}";
            //获取所有hashid数据集的key / value数据集合
            Dictionary<string, string> data = client.GetAllEntriesFromHash(hashId);
            return data;
        }
        /// <summary>
        /// 分布式锁
        /// </summary>
        /// <param name="key">锁key</param>
        /// <param name="lockExpirySeconds">锁自动超时时间(秒)</param>
        /// <param name="waitLockMs">等待锁时间(秒)</param>
        /// <returns></returns>
        public static bool Lock(string key, int lockExpirySeconds = 10, double waitLockSeconds = 5)
        {
            //间隔等待50毫秒
            int waitIntervalMs = 50;

            RedisClient client = new RedisClient("127.0.0.1",6379,null,2);
           
            string lockKey = "LockForSetNX:" + key;

            DateTime begin = DateTime.Now;
            using (client)
            {
                while (true)
                {
                    //循环获取取锁
                    if (client.SetNX(lockKey, new byte[] { 1 }) == 1)
                    {
                        //设置锁的过期时间
                        client.Expire(lockKey, lockExpirySeconds);
                        return true;
                    }

                    //不等待锁则返回
                    if (waitLockSeconds == 0) break;

                    //超过等待时间，则不再等待
                    if ((DateTime.Now - begin).TotalSeconds >= waitLockSeconds) break;

                    Thread.Sleep(waitIntervalMs);
                }
                return false;
            }
        }

        /// <summary>
        /// 删除锁 执行完代码以后调用释放锁
        /// </summary>
        /// <param name="key"></param>
        public static void DelLock(string key)
        {
            RedisClient client = new RedisClient("127.0.0.1", 6379, null, 0);
            string lockKey = "LockForSetNX:" + key;
            using (client)
            {
                client.Del(lockKey);
            }
        }
    }
}
