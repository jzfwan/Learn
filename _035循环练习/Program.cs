using System;

namespace _035循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////零以下结束 零重开 以上显示中间所有数
            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        for (int i = 1; i <= num; i++)
            //        {
            //            Console.Write(i + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    else if (num < 0)
            //    {
            //        return;
            //    }
            //}


            //1000以内所有“完数”  数的所有因子之和等于这个数   例：6=1+2+3
            for (int i = 1; i < 1001; i++)
            {
                string str = "1";
                int sum = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        str += "+" + j;
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i + "是完数"+str);
                }
            }
        }
    }
}
