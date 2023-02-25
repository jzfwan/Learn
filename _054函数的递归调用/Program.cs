using System;

namespace _054函数的递归调用
{
    class Program
    {
        static int F(int n)
        {
            if (n==0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }
            return F(n - 1) + F(n - 2);
        }
        static void Main(string[] args)
        {
            int res = F(40);
            Console.WriteLine(res);
            int res2 = F(2);
            Console.WriteLine(res2);
        }
    }
}
