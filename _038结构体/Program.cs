using System;

namespace _038结构体
{
    class Program
    {
        /*struct 结构名称           struct vector3
             * {                            {
             *  类型1 变量1;                    float x;
             *  类型2 变量2;                    float y;
             *  类型3 变量3;                    float z;
             *  .                           }
             *  .
             *  .
             *  类型N 变量N;
             * }*/
        ////下面就是使用3个float类型的变量来表示一个坐标类型
        //struct Position
        //{
        //    public float x;
        //    public float y;
        //    public float z;
        //}

        //枚举是可取范围只有几个时
        enum Direction
        {
            West,
            North,
            East,
            South
        }
        //结构体是几个类型的结合体
        struct Path
        {
            public float distance;
            public Direction dir;
        }
        static void Main(string[] args)
        {
            ////没有结构时通过三个float来表示敌人坐标
            //float enemy1X = 34;
            //float enemy1Y = 1;
            //float enemy1Z = 22;

            ////当使用结构体声明变量时，相当于使用结构体中所有变量去声明
            //Position enemy1Position;
            //enemy1Position.x = 34;//可以通过.加上属性名来访问结构体中指定的变量
            ////使用结构体让程序变得更清晰
            //Position enemy2Position;


            Path path1;
            path1.dir = Direction.East;
            path1.distance = 1000;
        }
    }
}
