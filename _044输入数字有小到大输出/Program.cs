using System;

namespace _044输入数字有小到大输出
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一些数字中有空格 从小到大排列

            //string str = Console.ReadLine();
            string str = "3,2,3,1,1,4,2,100";
            string[] strArray = str.Split(',');
            int[] numArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int temp = Convert.ToInt32(strArray[i]);
                numArray[i] = temp;
            }


            //Array.Sort(numArray);//排序 使用CLR给我们提供的方法进行排序(快速排序算法) 一般用这个来排序就行


            //冒泡排序法
            for (int j = 1; j <= str.Length - 1; j++)//外层for循环用来控制子for循环执行的次数
            {
                //让下面的for循环执行length-1次
                for (int i = 0; i < numArray.Length - 1; i++)
                {
                    //numArray[i]和numArray[i+1]作比较 把大的放后面
                    if (numArray[i + 1] < numArray[i])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = temp;
                    }
                }
            }

            ////冒泡排序的优化
            //for (int j = 1; j <= str.Length - 1; j++)//外层for循环用来控制子for循环执行的次数
            //{
            //    //让下面的for循环执行length-1次
            //    for (int i = 0; i < numArray.Length - j; i++)
            //    {
            //        //numArray[i]和numArray[i+1]作比较 把大的放后面
            //        if (numArray[i + 1] < numArray[i])
            //        {
            //            int temp = numArray[i];
            //            numArray[i] = numArray[i + 1];
            //            numArray[i + 1] = temp;
            //        }
            //    }
            //}


            for (int i = 0; i < numArray.Length; i++)//从小到大输出
            {
                Console.Write(numArray[i] + " ");
            }
        }
    }
}
