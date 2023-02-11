using System;

namespace _008自加自减
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 45;
            ////num1++;
            ////++num1;//不管在前在后都是让数值加1
            //int res1 = num1++;//先运算后自加 45
            //Console.WriteLine(res1 + ":" + num1);
            //int res2 = ++num1;//先自加后运算 46
            //Console.WriteLine(res2 + ":" + num1);

            int num1 = 45;
            int res1 = num1--;//先运算后自减 45
            int res2 = --num1;//先自减后运算 43
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
