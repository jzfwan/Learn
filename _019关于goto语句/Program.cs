using System;

namespace _019关于goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            goto mylabel;//用来控制跳转到某个标签的位置
            myInteger++;
            mylabel:Console.WriteLine(myInteger);
        }
    }
}
