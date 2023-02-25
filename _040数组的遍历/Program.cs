using System;

namespace _040数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 1, 32, 45, 132, 6, 64, 5, 78, 98, 78 };
            //scores.Length可以得到数组的长度

            //for循环
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //while循环
            //int i = 0;
            //while (i < scores.Length)
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}

            foreach (var temp in scores)//foreach会一次取得数组中的值，赋值给temp，然后执行循环体
            {
                Console.WriteLine(temp);
            }
        }
    }
}
