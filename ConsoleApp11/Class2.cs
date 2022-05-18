using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Class2//判断1到100的偶数有哪些
    {
        static public void function()
        {
            int i;
            int sum=0;
            for (i = 0; i <= 100; i++)
            {
                if (i%2==1)
                {
                    continue;
                }
                sum += i;
                Console.WriteLine(i);
            }   
           
        }
    }
}
