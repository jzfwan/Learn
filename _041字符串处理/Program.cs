using System;

namespace _041字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " | J Z F w a n . jzfWAN | ";
            ////string相当于char的数组
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //string res = str.ToLower();//把字符串转化成小写并返回，对原字符串没影响
            //string res2 = str.ToUpper();//把字符串转化成大写并返回，对原字符串没影响
            //string res3 = str.Trim();//去掉字符串前后空格并返回，对原字符串没影响
            //string res4 = str.TrimStart();//去掉字符串前空格并返回，对原字符串没影响
            //string res5 = str.TrimEnd();//去掉字符串后空格并返回，对原字符串没影响
            

            Console.WriteLine(str);
            //Console.WriteLine("小写数值" + "|" + res + "|");
            //Console.WriteLine("大写数值" + "|" + res2 + "|");
            //Console.WriteLine("去前后空格数值" + "|" + res3 + "|");
            //Console.WriteLine("去前空格数值" + "|" + res4 + "|");
            //Console.WriteLine("去后空格数值" + "|" + res5 + "|");

            string[] strArray = str.Split('.');//把原字符串按照指定字符进行拆分，得到一个字符串数组
            foreach (var temp in strArray)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
