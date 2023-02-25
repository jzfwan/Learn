using System;

namespace _050参数数组_定义一个参数个数不确定的函数
{
    class Program
    {
        static int Sum(int[] array)//如果函数定义了参数 在调用时一定要传递对应类型的参数 否则会报错
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];              
            }
            return sum;
        }
        //参数数组和数组参数(上面的)的不同，在于函数的调用
        //除参数数组外，所有函数额参数都是固定的，调用时要传递参数
        //调用参数数组的函数的时候，可以传递任意多个参数，然后编译器会帮我们自动拼成一个数组
        //参数如果是数组参数(上面的)，这个数组需要自己手动创建
        static int Plus(params int[] array)//定义了一个int类型的参数数组
        {

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(new int[] { 23, 4, 34, 32, 32, 42, 4 });
            Console.WriteLine(sum);

            int sum2 = Plus(23, 4, 5, 5, 5, 32, 423, 42, 43, 23, 42, 3);//参数数组就是帮我们减少了一个创建数组的过程
            Console.WriteLine(sum2);
        }
    }
}
