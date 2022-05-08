using System;
using Bool;

namespace ConsoleApp1
{
   class Program
    {
       int d=888;
       static int a = 35;
      static  int b = 34;
     static   int c;
        static void Main()
        {
            Program p = new Program();
            Console.WriteLine(p.haha);//调用haha方法
            c = a + b;
            
            Console.WriteLine(c);
         float age = 128.544444444444444444444444444444444444444444444444444444444f;
        
         float   age2 = 35.3f;
            if (age > 200)
            {
                Console.WriteLine("您的值不合法，只能输入-128到127");
            }
            else
            {
                
                demo b = new demo();//调用demo对象
               
                int x = b.Ttext(3,4);//调用demo对象中的Ttext方法
              


                Console.WriteLine(x);

                Console.WriteLine("age:" + age);
                Console.WriteLine("age2:" + age2);
                Console.ReadLine();
            }
           

        }


        
    }
    class demo1 {
       
    
    
    }
    class demo2 { }


}
namespace Bool
    {
    class  demo
    {
        int f;
        int d;
        int c;
     public int Ttext( int f,int d)
        {
            c = f + d;

          

           
            Console.WriteLine(c);
           
            Console.WriteLine("请输入");
           string str = Console.ReadLine();
            Console.WriteLine(str);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(str);
               
            }

            return 0;
        }
        int haha()
        {
            Console.WriteLine(d);
            return 0;
        }



    }



}




