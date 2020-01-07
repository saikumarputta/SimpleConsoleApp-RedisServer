using StackExchange.Redis;
using System;

namespace RedisConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            IDatabase db = redis.GetDatabase();
            var val = db.StringGet("k1");
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}
