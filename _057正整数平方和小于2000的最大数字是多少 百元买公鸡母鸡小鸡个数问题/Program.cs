using System;

namespace _057正整数平方和小于2000的最大数字是多少_百元买公鸡母鸡小鸡个数问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////正整数平方和小于2000的最大数字是多少
            //int sum = 0;
            //int k = 0;
            //while (sum<2000)
            //{
            //    k++;
            //    sum += k * k;                
            //}
            //Console.WriteLine(k - 1);


            //一百元买 公鸡5元一只 母鸡3元一只 小鸡1元3只  买几只公鸡几只母鸡几只小鸡
            for (int i = 0; i < 100 / 5; i++)
            {
                for (int j = 0; j <= (100 - i * 5) / 3; j++)
                {
                    int remainMoney = 100 - 5 * i - 3 * j;
                    int number = remainMoney * 3;
                    if (i + j + number == 100)
                    {
                        Console.WriteLine("公鸡买了" + i + "只，母鸡买了" + j + "只，小鸡买了" + number + "只");
                    }
                }
            }
        }
    }
}
