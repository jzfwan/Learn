using System;

namespace _043猜数字和字符串加密
{
    class Program
    {
        static void Main(string[] args)
        {
            ////猜0-50之间数字
            //Random random = new Random();
            //int number = random.Next(0, 51);
            //Console.WriteLine("输入一个0-50之间的数字");
            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > number)
            //    {
            //        Console.WriteLine("猜大了");
            //    }
            //    else if (num < number)
            //    {
            //        Console.WriteLine("猜小了");
            //    }
            //    else
            //    {
            //        Console.WriteLine("猜对了，结束");
            //        break;
            //    }
            //}

            //字符串加密
            string str = Console.ReadLine();
            string tempStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')//说明这个字符是小写字母
                {
                    int num = str[i];
                    num += 3;
                    char temp = Convert.ToChar(num);//取得字母向后移动三个位置后的字母
                    if (temp>'z')
                    {
                        temp = Convert.ToChar(temp - 'z' + 'a' - 1);//如果超出26个字母的范围，就转到开头'a'
                    }
                    tempStr += temp;
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    int num = str[i];
                    num += 3;
                    char temp = Convert.ToChar(num);//取得字母向后移动三个位置后的字母
                    if (temp > 'Z')
                    {
                        temp = Convert.ToChar(temp - 'Z' + 'A' - 1);//如果超出26个字母的范围，就转到开头'a'
                    }
                    tempStr += temp;
                }
                else
                {
                    tempStr += str[i];
                }
            }
            Console.WriteLine(tempStr);
        }
    }
}
