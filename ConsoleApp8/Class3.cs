using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class3//do while语句
    {
        static int i=1;
        static int sum = 0;
        static string count = Console.ReadLine();   
        static public void Do()
        {
            Console.WriteLine("请输入");
            do
            {
                sum += i;
                i++;
            } while ( count=="abc"&&i<=100);
           
            Console.WriteLine(sum);
        }
    }
}
