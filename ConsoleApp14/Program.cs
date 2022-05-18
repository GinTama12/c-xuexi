

Console.WriteLine("原始数据-----------------------");

int[,]nihao=new int[,] { { 1,2,3}, {4,5,6 },{7,8,9 } };
for (int i = 0; i < nihao.GetLength(0); i++)
{
    for (int h = 0; h < nihao.GetLength(0); h++)
    {
        Console.Write(nihao[i, h] + "\t");
    }
    Console.WriteLine();
}

ConsoleApp14.Class1.function();//调换数据
//计算1-100的累加和
Console.WriteLine("计算累加和-----------------------");
ConsoleApp14.Class3.fucnton();

Console.ReadLine();