using System;

namespace _036显式转换和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 123;
            int myInt = myByte;//小类型数据复制给大类型时，编译器会自动转换类型
            myByte = (byte)myInt;//大类型复制给小类型时，要进行显示转换(强制转换)   小类型=(目标类型)大类型;
            string str = "123";
            int num = Convert.ToInt32(str);//字符串储存的是整数时可转换，否则出错 字符串是小数时可转化成double
            Console.WriteLine(num);

            int mynum = 123123;
            string str2 = Convert.ToString(mynum);//可以把int float double byte类型转换成字符串
            string str3 = mynum + "";//int float double类型加空字符串 相当于把数字转换成字符串
            Console.WriteLine(str2);
        }
    }
}
