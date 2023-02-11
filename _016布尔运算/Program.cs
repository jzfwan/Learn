using System;

namespace _016布尔运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score = 99;
            //== != < > <= >=
            //bool res = score >= 50;//>=是比较运算符，如果是，返回true 不是，返回false
            int num1 = 34;
            int num2 = 67;
            bool res1 = num1 == num2;
            bool res2 = num1 != num2;
            bool res3 = num1 < num2;
            bool res4 = num1 > num2;
            bool res5 = num1 <= num2;
            bool res6 = num1 >= num2;
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            Console.ReadKey();
        }
    }
}
