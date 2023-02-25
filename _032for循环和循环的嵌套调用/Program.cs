using System;

namespace _032for循环和循环的嵌套调用
{
    class Program
    {
        static void Main(string[] args)
        {
            //100内被3整除，不被5整除的数
            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 3 == 0) && (i % 5 != 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            for (int i = 2; i < 1001; i++)
            {
                bool isZhishu = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i%j==0)
                    {
                        isZhishu = false;
                        break;
                    }
                }
                if (isZhishu)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
