using System;

namespace _021三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            //三元运算
            //<bool表达式或值>?<ture返回值>:<false返回值>
            string resStr = (i < 10) ? "小于10" : "大于或等于10";
            Console.WriteLine(resStr);
        }
    }
}
