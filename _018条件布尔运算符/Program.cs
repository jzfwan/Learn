using System;

namespace _018条件布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            //bool res = !var1;//!是取反  当var1为true是返回false 非
            //bool res1 = var1 & var2;//false 与
            //bool res2 = var1 | var2;//true 或
            //bool res3 = var1 ^ var2;//true 异或
            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //条件逻辑 &&与 ||或 !非 只能比较bool值
            //整体逻辑 &与 |或 ^异或 可以比较数值或bool值
            bool res1 = var1 && var2;//false 并且
            bool res2 = var1 || var2;//true 或
        }
    }
}
