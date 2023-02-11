using System;

namespace _011赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 12;
            int num3 = 12;
            int num4 = 12;
            int num5 = 25;
            num1 += 12;//num1=num1+12;
            num2 -= 12;//num2=num2-12;
            num3 *= 2;//num3=num3*12;
            num4 /= 12;//num4=num4/12;
            num5 %= 12;//num5=num5%12;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
        }
    }
}
