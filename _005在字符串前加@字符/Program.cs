using System;

namespace _005在字符串前加_字符
{
    class Program
    {
        static void Main(string[] args)
        {
            //前面有@可以多行
            string str1 = @"I'm a good man.
You are bad girl!";
            Console.WriteLine(str1);
            //双引号以外转义字符不识别，需要引号时双引号""
            string str2 = @"I'm a good man. \n"" You are bad girl!";
            Console.WriteLine(str2);
            //用@的好处
            string path = "c:\\xxx\\xxx\\xxx.doc";
            Console.WriteLine(path);
            string path2 = @"c:\xxx\xxx\xxx.doc";
            Console.WriteLine(path2);
        }
    }
}
