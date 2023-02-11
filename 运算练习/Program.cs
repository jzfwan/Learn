using System;

namespace 运算练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //习题1在Main方法中定义变量，用这些变量存储游戏中一个敌人应该有的一些属性，定义尽可能多的变量
            Console.WriteLine("习题1在Main方法中定义变量，用这些变量存储游戏中一个敌人应该有的一些属性，定义尽可能多的变量");
            string name_b = "砰砰怪";
            int hp_b = 200;
            int exp_b = 100;
            float ap_b = 10.5f;
            float dp_b = 5.5f;
            float as_b = 2.5f;
            float ms_b = 1.5f;
            Console.WriteLine("怪物名称：{0}\n怪物血量：{1}\n怪物经验值：{2}\n怪物攻击力：{3}\n怪物防御力：{4}\n怪物攻速：{5}\n怪物移速：{6}\n", name_b, hp_b, exp_b, ap_b, dp_b, as_b, ms_b);

            //习题2接受用户输入的两个整数，存储到两个变量里面，交换变量存储的值
            Console.WriteLine("习题2接受用户输入的两个整数，存储到两个变量里面，交换变量存储的值");
            int a = 12;
            int b = 34;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b + "\n");

            //习题3编写一个控制台应用程序，要求用户输入4个int值，并显示他们的乘积
            Console.WriteLine("习题3编写一个控制台应用程序，要求用户输入4个int值，并显示他们的乘积");
            Console.WriteLine("输入整数1");
            string num1 = Console.ReadLine();
            int res1 = Convert.ToInt32(num1);
            Console.WriteLine("输入整数2");
            string num2 = Console.ReadLine();
            int res2 = Convert.ToInt32(num2);
            Console.WriteLine("输入整数3");
            string num3 = Console.ReadLine();
            int res3 = Convert.ToInt32(num3);
            Console.WriteLine("输入整数4");
            string num4 = Console.ReadLine();
            int res4 = Convert.ToInt32(num4);
            int mul = res1 * res2 * res3 * res4;
            Console.WriteLine("乘积为：" + mul);

            //习题4从键盘输入一个三位的正整数，按数字的相反顺序输出
            Console.WriteLine("习题4从键盘输入一个三位的正整数，按数字的相反顺序输出\n");
            Console.WriteLine("输入三位整数");
            string t1 = Console.ReadLine();
            int i = Convert.ToInt32(t1);
            int i1 = i / 100;
            int i3 = i % 10;
            int i2 = ((i - i3) / 10) % 10;
            Console.WriteLine("第一位数字：{0}\n第二位数字：{1}\n第三为数字：{2}", i1, i2, i3);

            //习题5编写一个程序，输入梯形的上底 下底 和高 ，计算出来梯形的面积并显示出来
            Console.WriteLine("习题5编写一个程序，输入梯形的上底 下底 和高 ，计算出来梯形的面积并显示出来");
            Console.WriteLine("输入上底长");
            float uw = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("输入下底长");
            float dw = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("输入高");
            float hw = Convert.ToSingle(Console.ReadLine());
            float size = (uw + dw) * hw / 2;
            Console.WriteLine(size);

            //习题6计算半径为n的圆的周长和面积
            Console.WriteLine("习题6计算半径为n的圆的周长和面积");
            Console.WriteLine("输入圆的半径");
            float n = Convert.ToSingle(Console.ReadLine());
            double c1 = n * 3.14 * 2;
            double a1 = n * n * 3.14;
            Console.WriteLine("周长为：" + c1);
            Console.WriteLine("面积为：" + a1);

            Console.WriteLine("习题完成");
            Console.ReadKey();
        }
    }
}
