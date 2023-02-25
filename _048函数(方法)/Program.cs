using System;

namespace _048函数_方法_
{
    class Program
    {
        //static 返回类型 函数名称(参数,参数){函数体....return 返回值;} 可以没有参数也可以有1个或多个参数
        static void Write()//void表示空的返回值，就是不需要返回值
        {
            //函数体 方法体  可以写0行1行多行语句
            Console.WriteLine("Text output from function");
            return;//这个语句用来结束当前函数
        }
        static int Plus(int num1, int num2)//函数定义的时候，参数我们叫做形式参数 形参   num1和num2就是形参  形参的值时不确定的
        {
            int sum = num1 + num2;
            return sum;
        }
        static void Main(string[] args)
        {
            Write();//调用函数    函数();
            int num1 = 45;
            int num2 = 90;
            int res1 = Plus(num1, num2);//当调用函数的时候，这里传递的参数就是实际参数 实参，实参的值会传递给形参做运算
            int res2 = Plus(45, 20);//定义了res1和res2来接受返回值
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
