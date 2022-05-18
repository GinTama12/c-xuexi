//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Class1
    {
        public static void sWitch()
        {
            Console.WriteLine("请输入银行的简称：");
            string str = Console.ReadLine();
            switch (str)
            {
                case "ICBC":
                    Console.WriteLine("中国工商银行");
                    break;
                case "CBC":
                case "cbc":
                    Console.WriteLine("中国建设银行");
                    break;
                case "ABC":
                case "abc":
                    Console.WriteLine("中国农业银行");
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;

            }
            Console.ReadLine();


        }
    }
}
