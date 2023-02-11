using System;

namespace _007数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 45;
            //int num2 = 13;
            ////int res1;
            //int res1 = num1 + num2;
            //int res2 = num1 - num2;
            //int res3 = num1 * num2;
            //int res4 = num1 / num2;
            //int res5 = num1 % num2;
            //double res = 123.4 % 2;
            //int num3 = 45;
            //double num4 = 3.1;
            ////操作类型不一样，返回结果与类型大的保持一致（数数值较长的）
            //double res6 = num3 + num4;
            ////加减乘除求余两边的操作数都是整数，结果是整数，不能整除部分，自动忽略小数
            //Console.WriteLine("加法：{0}\n减法：{1}\n乘法：{2}\n除法：{3}\n求余：{4}", res1, res2, res3, res4, res5);
            //Console.WriteLine(res);
            //关于加法运算符更多的使用
            //连接字符串相加
            //string str1 = "123adb";
            //string str2 = "jzfwan";
            //string str = str1 + str2;
            //Console.WriteLine(str);
            //字符串与数字相加，数字变字符串后连接，结果是字符串
            string str1 = "123";
            int num = 456;
            string res1 = str1 + num;
            //字符串转整数后可运算
            int res2 = Convert.ToInt32(str1) + num;
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
