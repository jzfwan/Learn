using System;

namespace _055循环和函数练习
{
    class Program
    {
        static int Factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            ////100高落球，每次反弹一半高度，第10次时，共经过几米？第10次反弹多高？
            //float height = 100;
            //float distance = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    distance += height;
            //    height /= 2;
            //}
            //Console.WriteLine("经过" + distance + "米，第10次反弹了" + height / 2 + "米");


            //1+2!+3!+...+20!的和   阶乘  例：5!=1*2*3*4*5  10!=1*2*3*4*5*6*7*8*9*10
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += Factorial(i);
            }
            Console.WriteLine(sum);
        }
    }
}
