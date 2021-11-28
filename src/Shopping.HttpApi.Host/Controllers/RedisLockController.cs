using System;
using System.Collections.Generic;
using Education.Common;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.Redis;
using Shopping.Hlep;
using StackExchange.Redis;

namespace Shopping.Controllers
{
    public class RedisLock
    {

        [ApiController]
        public class RedisLockController : ControllerBase
        {
            //Redis连接
            public static IDatabase database1 = null;
            //静态对象
            private static object lockobj = new object();
            /// <summary>
            /// 测试秒杀抢库存(分布式锁)不是完全开源
            /// </summary>
            /// <returns></returns>
            [Route("api/RedisLock/DownOrder")]
            [HttpGet]
            public IActionResult DownOrder(Guid skuId)
            {
                //连接Redisopp
                RedisClient client = new RedisClient("127.0.0.1", 6379, null, 2);
                string hashId = $"product_{skuId}";
                //判断是否获取到锁
                if (RedisHelp.Lock(hashId) == true)
                {
                    try
                    {
                        //获取库存
                        string data = client.GetValueFromHash(hashId, "StoreNum");
                        int storeNum = Convert.ToInt32(data);
                        //判断
                        if (storeNum > 0)//50
                        {
                            client.SetEntryInHash(hashId, "StoreNum", (storeNum - 1).ToString());//49
                            Dictionary<string, string> productData = client.GetAllEntriesFromHash(hashId);

                            productData["StoreNum"] = "1";

                            RabbitMQHeleper<Dictionary<string, string>> mq = new RabbitMQHeleper<Dictionary<string, string>>();
                            mq.numOrder = productData;
                            int res = mq.RabbitSet();
                            if (res > 0)
                            {
                                return Ok("恭喜抢购成功");
                            }
                            //解锁（释放锁）
                            RedisHelp.DelLock(hashId);
                            return Ok("抢购失败");
                        }
                        else
                        {
                            //解锁（释放锁）
                            RedisHelp.DelLock(hashId);
                            return Ok("抢购失败");
                        }
                    }
                    catch (Exception)
                    {
                        //解锁（释放锁）
                        RedisHelp.DelLock("TestLock");
                        
                        throw;
                    }
                    
                }
                return Ok();
            }
        }
    }
}
