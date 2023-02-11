using System;

namespace _010接收输入现实和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个数字");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("输入第二个数字");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int sum = num1 + num2;
            Console.WriteLine("结果为：" + sum);
        }
    }
}
