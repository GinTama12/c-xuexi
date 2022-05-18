// See https://aka.ms/new-console-template for more information


Demo demo=new Demo();//调用对象
//demo.Function();//使用方法
demo.Function1();   
//demo.Function3();   

class Demo
{ 
   public void Function()
    {
        int sum = 0;
        int i = 1;
        while (i<=100)
        {
            sum+=i;
            ++i;    
        }
        Console.WriteLine(sum);
    }
    public void Function1()
    {
        int sum = 0;
        int i;
        int sum1 = 0;
        for (i=1; i<100; )
        {
            sum += i;
            i++;
            sum1=sum+i;    
            Console.WriteLine(sum+"+"+i+"="+sum1);
        }
        Console.WriteLine(sum1);
    }
    public void Function3()
    {
        int i = 1;
        int sum = 0;
        do
        {
           
            sum += i;
            i++;

        } while (i<=100);
        Console.WriteLine(sum); 
    }

}