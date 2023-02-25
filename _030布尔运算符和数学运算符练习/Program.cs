using System;

namespace _030布尔运算符和数学运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////求最大值和最小值
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //int max, min;
            //if (num1 > num2)
            //{
            //    max = num1;
            //}
            //else
            //{
            //    max = num2;
            //}
            //if (num3 > max)
            //{
            //    max = num3;
            //}
            //if (num4 > max)
            //{
            //    max = num4;
            //}

            //if (num1 > num2)
            //{
            //    min = num2;
            //}
            //else
            //{
            //    min = num1;
            //}
            //if (num3 < min)
            //{
            //    min = num3;
            //}
            //if (num4 < min)
            //{
            //    min = num4;
            //}
            //Console.WriteLine("最大值是：" + max);
            //Console.WriteLine("最小值是：" + min);




            //先输入两个整数，在输入0加1减2乘3除，计算结果
            Console.WriteLine("输入第一个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数字");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入计算方式");
            int operation = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            switch (operation)
            {
                case 0:
                    res = num1 + num2;
                    break;
                case 1:
                    res = num1 - num2;
                    break;
                case 2:
                    res = num1 * num2;
                    break;
                case 3:
                    res = num1 / num2;
                    break;
            }
            Console.WriteLine("计算结果为：" + res);
        }
    }
}
