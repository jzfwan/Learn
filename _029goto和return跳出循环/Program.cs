using System;

namespace _029goto和return跳出循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //    while (true)
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        if (num == 0)
            //        {
            //            goto myLabel;
            //        }
            //    }
            //myLabel:
            //    Console.WriteLine("跳出循环了");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    return;//用来终止方法，表示方法运行结束，剩余代码不执行
                }
            }
            //Console.WriteLine("跳出循环了");//语句没执行
        }
    }
}
