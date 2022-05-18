using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Class1
    {
        static public void function()
        {
            int x;
            int y;
            
            for (x = 1; x <=9; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y+ "×" + x+"= "+x*y+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}