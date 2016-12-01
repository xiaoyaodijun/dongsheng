using ServiceStack.Redis;
using System.Configuration;

namespace Common.AliYun
{
    public class TredisInfo
    {
        /// <summary>
        /// redis链接字符串
        /// </summary>
        public static string RedisConnection = ConfigurationManager.AppSettings["redisConnection"];

        /// <summary>
        /// Hosts
        /// </summary>
        private static string[] ReadWriteHosts = new[] { RedisConnection };

        /// <summary>
        /// 最大连接池
        /// </summary>
        private static int MaxPool = 20;

        /// <summary>
        /// 连接池超时时间
        /// </summary>
        private static int TimeOut = 60;

        /// <summary>
        /// Redis连接池
        /// </summary>
        private static readonly PooledRedisClientManager RedisPoolManager = new PooledRedisClientManager(MaxPool, TimeOut, ReadWriteHosts);

        /// <summary>
        /// 创建一个Redis实例
        /// </summary>
        /// <returns></returns>
        public static IRedisClient GetRedisClient()
        {
            //RedisConfig.VerifyMasterConnections = false; //需要设置
            IRedisClient redisClient = RedisPoolManager.GetClient();
            // RedisNativeClient redisNativeClient = (RedisNativeClient)redisClient;
            //redisNativeClient.Client = null;
            return redisClient;
        }

        /// <summary>
        /// 释放Redis实例资源
        /// </summary>
        /// <param name="redisClient"></param>
        public static void Dispose(IRedisClient redisClient)
        {
            redisClient?.Dispose();
        }
    }
}
