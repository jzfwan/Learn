using System;

namespace _004自定义变量存储主角信息
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "jzfwan";
            int hp = 100;
            int level = 34;
            float exp = 345.3f;
            long l = 1000000000000000000L;
            Console.WriteLine("主角名：\"{0}\" \n血量：{1} \n等级：{2} \n经验：{3}", name, hp, level, exp);
        }
    }
}
