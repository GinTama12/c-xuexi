using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class4
    {
        static int i = 1;
        static int sum = 0;
        static int sum1 = 0;    
        static public void For()
        {
            for (; i < 100; )
            {
                sum = sum + i;

                i++;
                sum1 = sum + i;


                Console.WriteLine(sum + "+" + i+ "=" + sum1);
            }
            Console.WriteLine(sum1); 
        }
    }
}
