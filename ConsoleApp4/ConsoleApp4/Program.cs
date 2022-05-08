using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Demo demo = new Demo();
            // Demo.demo1 = new Demo();
            //Demo.Ifpanduan();
            Program.Ifpanduan();
            
            //Console.WriteLine(i++);
            Console.ReadLine();
        }
       static void Ifpanduan()
        {
            string k;
            Console.WriteLine(7 & 8);
        }
    }
    class Demo
    {
     static public void Ifpanduan()
        {

            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入用户密码:");
            string pwd = Console.ReadLine();
            if (name == "mr" && pwd == "fn2681521")
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
        }
    }
}
