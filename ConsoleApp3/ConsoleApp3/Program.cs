using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 90;
            int C = 89;
            int Csharp = 90;
            int Sql = 60;
            Console.WriteLine("C的成绩：" + C);
            Console.WriteLine("C#的成绩：" + Csharp);
            Console.WriteLine("Sql的成绩：" + Sql);
            Console.WriteLine();
            Console.WriteLine("C#和SQL的分数差:" + (Csharp - Sql));
            Console.WriteLine("该学员的平均成绩：" + (C + Csharp + Sql) / 3);
            Console.Read();



            Console.WriteLine("Hello World!");
        }
    }
}
