namespace ConsoleApp15
{
    internal class Class2//计算1到100的累加和
    {
        static public void fucnton()
        {
            Console.WriteLine("请购买数量：");
           
            int k;
            int b=Convert.ToInt32(Console.ReadLine()) ;
            for (k = 0; k <= 100; k++)
            {
                if (k == b)
                {
                    Console.WriteLine("只能使用" + k + "次请付费");
                    break;
                    

                }
               
               
                else
              

                {
                    Console.WriteLine("请累加到多少：" + "使用第" + (k+1) + "次");
                    long j = Convert.ToInt32(Console.ReadLine());//输入累加和
                    long i;
                    long sum = 0;
                    for (i = 0; i <= j; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);

                }


            }


        }


    }
}
