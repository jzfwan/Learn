using System;

namespace _034循环结构练习_字符和字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1到5的平方值，用for  while  do while语句
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            //int index = 1;
            //while (index<6)
            //{
            //    Console.WriteLine(index * index);
            //    index++;
            //}

            //int index2 = 1;
            //do
            //{
            //    Console.WriteLine(index2 * index2);
            //    index2++;
            //} while (index2<6);



            ////5个大写字母，如果不满足要求，提示信息重新输入
            //string str = "asdaASD";
            //char c = str[0];//通过  变量[索引]  来访问变量中某个字符 默认从0开始
            //Console.WriteLine(c);
            //char c =  'z';//没个字符相当于一个整数，字符存取时使用这个整数，字符可以当整数来用
            //int num = c;
            //Console.WriteLine(num);
            while (true)
            {
                string str = Console.ReadLine();
                bool isAllUpperChar = true;
                for (int i = 0; i < 5; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {

                    }
                    else
                    {
                        isAllUpperChar = false;
                        break;
                    }
                }
                if (isAllUpperChar == false)
                {
                    Console.WriteLine("不满足要求，重新输入");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
