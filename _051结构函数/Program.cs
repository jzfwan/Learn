using System;

namespace _051结构函数
{
    //struct CustomName
    //{
    //    public string firstName;
    //    public string lastName;
    //    public string GetName()//结构函数可以调用固定组合
    //    {
    //        return firstName + lastName;
    //    }
    //}


    struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);//距离=平方根(x*x+y*y+z*z)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //CustomName myName;
            //myName.firstName = "jzf";
            //myName.lastName = "wan";
            //Console.WriteLine("我的名字是：" + myName.firstName + myName.lastName);
            //Console.WriteLine("我的名字是：" + myName.GetName());


            Vector3 myVector3;
            myVector3.x = 3;
            myVector3.y = 3;
            myVector3.z = 3;
            Console.WriteLine(myVector3.Distance());
        }
    }
}
