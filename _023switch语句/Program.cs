using System;

namespace _023switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 3;
            switch (state)
            {
                case 0:
                    Console.WriteLine("开始界面");
                    break;
                case 1:
                    Console.WriteLine("战斗中");
                    break;
                case 2:
                    Console.WriteLine("暂停");
                    break;
                case 3:
                    Console.WriteLine("胜利");
                    break;
                case 4://可以连写 代表4和5都是“失败”
                case 5:
                    Console.WriteLine("失败");
                    break;
                default:
                    Console.WriteLine("state超出游戏状态取值范围");
                    break;
            }
        }
    }
}
