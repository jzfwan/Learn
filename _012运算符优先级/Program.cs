using System;

namespace _012运算符优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12 + 90;
            int num1 = 12 + 90 * 2;
            int num2 = (12 + 90) * 2;//程序中表达式优先运算优先级高的运算符，可用括号()改变
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
