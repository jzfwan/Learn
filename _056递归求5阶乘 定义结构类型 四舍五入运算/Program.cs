using System;

namespace _056递归求5阶乘_定义结构类型_四舍五入运算
{
    ////学生成绩  结构体
    //struct Student
    //{
    //    public string number;
    //    public string name;
    //    public bool isGirl;
    //    public int score;
    //    public void Show()
    //    {
    //        Console.WriteLine("姓名：" + name + " 学号：" + number + " 性别：" + (isGirl?"女":"男") + " 分数：" + score);
    //    }
    //}
    class Program
    {
        ////计算5!
        //static int Factorial(int n)
        //{
        //    if (n==1)
        //    {
        //        return 1;
        //    }
        //    return n * Factorial(n - 1);
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));


            //Student stu1;
            //stu1.name = "jzf";
            //stu1.number = "13546";
            //stu1.isGirl = false;
            //stu1.score = 100;
            //stu1.Show();


            double number = Convert.ToDouble(Console.ReadLine());
            int numberInteger = Convert.ToInt32(number);
            //#region 现在版本好像是四舍五入
            //double numberDouble = number - numberInteger;
            //if (numberDouble >= 0.5f)
            //{
            //    numberInteger++;
            //}
            //#endregion
            Console.WriteLine(numberInteger);
        }
    }
}
