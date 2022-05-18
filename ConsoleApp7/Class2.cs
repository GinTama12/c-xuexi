using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class2
    {

        public static void panduan()
        {
            Console.WriteLine("请输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 1)
                    {
                        Console.WriteLine("这是闰年");
                    }
                    else
                    {
                        Console.WriteLine("这不是闰年");
                    }
                }
                else
                {
                    Console.WriteLine("这是闰年");
                }
            }
            else
            {
                Console.WriteLine("这不是闰年");
            }
        }
    }
}
