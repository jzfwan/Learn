using System;

namespace _028continue终止当前循环继续下个循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    index++;
            //    if (index == 5)//到5时跳过5到6
            //    {
            //        continue;
            //    }
            //    if (index == 10)//到10时跳出循环
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);
            //}
            int sum = 0;
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                if (num % 2 == 1)
                {
                    continue;
                }
                sum += num;
            }
        }
    }
}
