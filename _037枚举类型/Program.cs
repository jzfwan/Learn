using System;

namespace _037枚举类型
{
    //枚举类型定义
    enum GameState:byte//类型名称  :后面为储存类型 默认为int
    {
        //类型值      value1,value2,value3,...valueN
        Pause = 100,//默认代表整数0  100
        Faild = 101,//默认代表整数1  101
        Success = 102,//默认代表整数2  102
        Start = 200//默认代表整数3  103
    }
    class Program
    {
        static void Main(string[] args)
        {
            //利用定义好的枚举类型去声明变量
            GameState state = GameState.Start;
            if (state == GameState.Start)//枚举类型比较
            {
                Console.WriteLine("游戏开始状态");
            }
            Console.WriteLine(state);
        }
    }
}
