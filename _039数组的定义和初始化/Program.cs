using System;

namespace _039数组的定义和初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            //float int string等等类型  类型数据的组
            ////第一种：使用这种方式赋值时，一定要在声明数组时赋值   可随时增加减少值数量
            //类型[] 变量 = {值1,值2,值3,值N};
            //int[] scores = { 23, 45, 65, 12, 78, 65, 32, 45, 12, 45 };



            ////第二种：
            ///类型[] 变量 = new 类型[值数量];
            //int[] scores = new int[10];
            //或

            //类型[] 变量;
            //变量 = new 类型[值数量];
            //int[] scores;
            //scores = new int[10];



            ////第三种：第一种与第二种的结合
            int[] scores = new int[10] { 1, 23, 65, 45, 32, 12, 45, 6, 42, 16 };
            //所有数组在访问索引不存在的值时会出现异常exception
        }
    }
}
