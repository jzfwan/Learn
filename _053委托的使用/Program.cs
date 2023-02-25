using System;

namespace _053委托的使用
{
    //定义委托和函数差不多  区别在于
    //1.定义委托需要加上delegate关键字
    //2.委托的定义不需要函数体
    //delegate 类型 名字(类型1 值1,类型2 值2);
    public delegate double MyDelegate(double param1, double param2);
    class Program
    {
        static double Multiply(double param1,double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            MyDelegate de;//利用定义的委托类型声明了一个新的变量
            de = Multiply;//当给一个委托的变量赋值时  返回值跟参数列表必须一样 否则无法赋值
            Console.WriteLine(de(2.0, 34.1));
            de = Divide;
            Console.WriteLine(de(2.0, 34.1));
        }
    }
}
