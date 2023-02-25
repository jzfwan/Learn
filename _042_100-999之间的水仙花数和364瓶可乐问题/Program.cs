using System;

namespace _042_100_999之间的水仙花数和364瓶可乐问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////第一题找出100到999之间的水仙花数
            //for (int i = 100; i < 1000; i++)
            //{
            //    int bai = i / 100;
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int sum = bai * bai * bai + shi * shi * shi + ge * ge * ge;
            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //第二题有364瓶可乐，3个空瓶换一瓶，一共可以喝几瓶可乐，剩几瓶空瓶
            int sum = 364;//有的瓶数
            int numEmpty = sum;//现在有多少空瓶
            while (numEmpty >= 3)
            {
                sum += numEmpty / 3;
                int newCount = numEmpty / 3;//可以兑换多少新可乐
                int remainEmpty = numEmpty % 3;//没兑换剩余空瓶
                numEmpty = newCount + remainEmpty;//兑换后有多少空瓶 
            }
            Console.WriteLine("喝了" + sum + "瓶,还剩"+numEmpty+"瓶空瓶");
        }
    }
}
