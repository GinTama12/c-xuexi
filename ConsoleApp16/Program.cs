namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生总数：");
            int count = Convert.ToInt32(Console.ReadLine());
            int[,] achievement = new int[count, 4];
            for (int i = 0; i < count; i++)
            {
                Console.Write("请输入第{0}个学生的编号：", i + 1);
                achievement[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入语文成绩:");
                achievement[i, 1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入数学成绩:");



                achievement[i, 2] = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入英语成绩:");
                achievement[i, 3] = Convert.ToInt32(Console.ReadLine());



            }
            Console.WriteLine("学生成绩结果如下");
            Console.WriteLine("---------------");
            Console.WriteLine("学生编号\t语文成绩\t数学成绩\t英语成绩\t平均成绩\t总成绩\t");
            for (int i = 0; i < achievement.GetLongLength(0); i++)
            {
                double sum = 0, ave = 0;
                for (int j = 0; j < achievement.GetLongLength(1); j++)
                {
                    Console.Write(achievement[i, j] + "\t\t");
                    if (j > 0)
                    {
                        sum += achievement[i, j];
                    }
                }
                ave = sum / 3;
                Console.Write(ave + "\t\t" + sum +"\n");
            }
        }
    }
}