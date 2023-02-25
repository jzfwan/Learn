using System;

namespace _052函数的重载
{
    //函数名相同  参数不同  是函数的重载 通过识别参数调用不同函数

    class Program
    {
        static int MaxValue(params int[] array)
        {
            Console.WriteLine("int类型调用");
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        static double MaxValue(params double[] array)
        {
            Console.WriteLine("double类型调用");
            double maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }


        static void Main(string[] args)
        {
            int res = MaxValue(234, 23, 4);//编译器会根据传递的实参类型来选择调用的函数
            double res2 = MaxValue(23.124, 12.312, 34.41654);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}