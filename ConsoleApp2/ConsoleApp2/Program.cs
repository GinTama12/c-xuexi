using System;

namespace ConsoleApp2
{
    class Program
    {
        //string a = "bababab";
        //static string b = "ddddd";
        //const double PI = 3.1415926;//初始化常量
        //const int P1 = P2 * 2;
        //const int P2 = 368;
        //const PI= 3.14;

        //static readonly int P3 = P4 * 2;
        //static readonly int P4 = 368;
        /// <summary>
        /// dsadsajkdjsakjdsa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double R;
            Console.WriteLine("请输入圆半径:");
            R = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("圆的面积：" + PI * R * R);

            //Console.WriteLine( b);
            //Program p = new Program();
            //  Console.WriteLine(new Program().f());//创建对象用对象引用方法

            //  Console.WriteLine(new Program().f());
            //Program p = new Program();
            //Console.WriteLine(p. f());
            //xs xs = new xs();
            //Console.WriteLine(xs.f());

            //Console.Read();
            //Console.WriteLine("欢迎登录");
            //Console.WriteLine("请输入:");
            //string name = Console.ReadLine();
            //Console.WriteLine("当前登录用户："+name);
            //string dd="我是倒计时卡就的撒";
            //Console.WriteLine("hello wolod");
            //Console.Read();

            //Consume consume = new Consume();
            //Consume.Record();

            //Console.WriteLine("const常量的效果");
            //Console.WriteLine("P1的值" + P1);
            //Console.WriteLine("P2的值" + P2);
            //Console.WriteLine("readonly常量的效果");
            //Console.WriteLine("P3的值" + P3);
            //Console.WriteLine("P4的值" + P4);
           
            
          


            Console.Read();


        }
        int f()
        {
            Console.WriteLine();
            return 0;

           


        }
    }
    class xs

    {
        string a = "我是甄辉";
        public int f()
        {
            Console.WriteLine(a);
            return 0;
        }

    }
    class Card //信用卡
    {
        public string Money { get; set;  }

    }
   static class Consume //信用卡消费记录
    {
      static  public void Record()
        {
            Console.WriteLine("信用卡消费记录\n");//输出信用卡消费记录
            Card pCard = new Card() { Money = "8000 " };//给信用卡赋值8000
            Console.WriteLine("信用卡的总额度：" + pCard.Money);//显示信用卡额度
            Card sCard = pCard;
            sCard.Money = "3000";
            Console.WriteLine("信用卡的消费记录" + pCard.Money);
        }
    }

}
