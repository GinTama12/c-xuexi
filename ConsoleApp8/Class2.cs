using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class2
    {
        static public void sum()
        {
            int sum = 0;
            int sum1 = 0;
            for (int i = 1; i <=2; i++)
            {
               

                sum1 = sum + i;
               

                Console.WriteLine(sum + "+" + i + "=" + sum1);
                sum = sum + i;

            }
            Console.WriteLine(sum1);
        }
    }
}
