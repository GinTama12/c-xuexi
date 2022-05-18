using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class1
    {
        static int sum = 0;
        static int i = 1;
        static int sum1 = 0;
        static public void xunhuang()
        {
           //int sum = 0;//和
           //int i = 1;//循环次数
            //int sum1 = 0;
            while (i <2) 
            {
                sum = sum + i;
               
                i++;
                sum1 = sum + i;

                Console.WriteLine(sum + "+" + i+ "="+sum1);


            }
            Console.WriteLine("1累加到"+i+"="+sum1); 
            
            
        }
        static public void panduan()//判断数据是否准确
        {
            if (sum1==sum1)
            {
                Console.WriteLine("数据准确");

            }
            else
            {
                Console.WriteLine("数据错误");    
            }
        }
    }
}