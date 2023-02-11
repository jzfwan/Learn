using System;

namespace _003变量类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数
            byte myByte = 34;
            int score = 6000;
            long count = 1000000000000300;
            Console.WriteLine("byte:{0} int:{1} long:{2}",myByte,score,count);

            //浮点
            float myFloat = 12.5f;
            double mydouble = 12.6;
            Console.WriteLine("float:{0} double:{1}", myFloat, mydouble);

            //非数值
            char myChar='a';
            string myString = "";
            string myString2 = "a";
            bool myBool = true;//布尔类型
            Console.WriteLine("char:{0} string1:{1} string2:{2} bool:{3}",myChar,myString,myString2,myBool);

        }
    }
}
