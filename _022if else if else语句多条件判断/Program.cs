using System;

namespace _022if_else_if_else语句多条件判断
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("有几分？");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("优秀");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("良");
            }
            else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("中");
            }
            else
            {
                Console.WriteLine("继续努力");
            }
        }
    }
}
