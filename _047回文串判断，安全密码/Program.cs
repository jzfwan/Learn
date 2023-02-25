using System;

namespace _047回文串判断_安全密码
{
    class Program
    {
        static void Main(string[] args)
        {
            ////回文串判断
            //string str = Console.ReadLine();
            //bool isHui = true;
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    //i str.Length-1-i
            //    if (str[i]!=str[str.Length-1-i])
            //    {
            //        isHui = false;
            //        break;
            //    }
            //}
            //if (isHui)
            //{
            //    Console.WriteLine("是回文串");
            //}
            //else
            //{
            //    Console.WriteLine("不是回文串");
            //}



            //安全密码,不符合重输
            while (true)
            {
                string str = Console.ReadLine();
                if (str.Length >= 8 && str.Length <= 16)
                {
                    bool isHaveUpper = false;
                    bool isHaveLower = false;
                    bool isHaveNumber = false;
                    bool isHaveSpecial = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] >= 'A' && str[i] <= 'Z')
                        {
                            isHaveUpper = true;
                        }
                        if (str[i] >= 'a' && str[i] <= 'a')
                        {
                            isHaveLower = true;
                        }
                        if (str[i] >= '0' && str[i] <= '9')
                        {
                            isHaveNumber = true;
                        }
                        if (str[i] == '~' || str[i] == '!' || str[i] == '@' || str[i] == '#' || str[i] == '$' || str[i] == '%' || str[i] == '^')
                        {
                            isHaveSpecial = true;
                        }
                    }
                    int count = 0;
                    if (isHaveUpper)
                    {
                        count++;
                    }
                    if (isHaveLower)
                    {
                        count++;
                    }
                    if (isHaveNumber)
                    {
                        count++;
                    }
                    if (isHaveSpecial)
                    {
                        count++;
                    }
                    if (count >= 3)
                    {
                        Console.WriteLine("密码安全");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("密码不安全");
                    }
                }
                else
                {
                    Console.WriteLine("长度不符合要求，限8-16字符");
                }
            }
        }
    }
}
