using System;

namespace _020if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = true;
            //if (var)
            //    Console.WriteLine("------");
            //Console.WriteLine("if语句后的语句");
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            //if (score > 50)
            //{
            //    Console.WriteLine("大于50");
            //}
            //if(score<=50)
            //{
            //    Console.WriteLine("小于等于50");
            //}
            if (score > 50)
            {
                Console.WriteLine("大于50");
            }
            else
            {
                Console.WriteLine("小于等于50");
            }
        }
    }
}
