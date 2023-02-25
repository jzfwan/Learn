using System;

namespace _031for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;//计数器
            //int sum = 0;//存储和
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sum += i;
            //        count++;
            //        Console.WriteLine(i + "可以被7整除");
            //        if (count == 5)
            //        {
            //            Console.WriteLine("5个的和是："+sum);
            //            sum = 0;//重置存储和
            //            count = 0;//重置计数器
            //        }
            //    }
            //}


            for (int i = 1; i < 100; i++)
            {
                int pf = i * i;
                double gen = Math.Sqrt(i);//Math.Sqrt()数字的平方根
                Console.WriteLine("平方是：" + pf + "平方根是" + gen);
            }
        }
    }
}
