using System;

namespace _045每天少一半_1_第N天只剩1_一共有几
{
    class Program
    {
        static void Main(string[] args)
        {
            //////每天少一半+1,第N天只剩1,一共有几
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    count = (count + 1) * 2;
            //}
            //Console.WriteLine(count);


            //输入n(n<=100)个整数，找出其中最小数，将它与最前面的数交换后输出
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            int[] numArray = new int[strArray.Length];
            int minIndex = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(strArray[i]);
            }
            int min = numArray[0];
            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i]<min)
                {
                    minIndex = i;
                    min = numArray[i];
                }
            }
            //把最小数字与索引0的数字交换位置
            int temp = numArray[0];
            numArray[0] = numArray[minIndex];
            numArray[minIndex] = temp;
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i] + " ");
            }
        }
    }
}
