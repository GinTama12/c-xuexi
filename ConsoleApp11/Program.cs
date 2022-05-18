//ConsoleApp11.Class1.function();
//ConsoleApp11.Class2.function();
//int iRow, iConlum;
//for (iRow=1;iRow<10;iRow++)
//{
//    for (iConlum = 1; iConlum <= iRow; iConlum++)
//    {
//        Console.WriteLine("{0}*{1}={2}",iConlum,iRow,iRow*iConlum);
//    }
//     Console.WriteLine();   
//}
Console.WriteLine("原始数据");
int[,]arr=new int[,] { {1,2,3 },{4,5,6 },{7,8,9 } };   
for(int i = 0; i < arr.GetLength(0); i++)
{
   for(int j = 0; j <arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j]+"  ");
    }
   Console.WriteLine();
}
Console.WriteLine("调换之后的数据");
int temp;
for(int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp=arr[i,j];  
        arr[i,j]=arr[j,i];   
        arr[j,i]=temp;
        Console.Write(arr[i, j] + "  ");
    }
    Console.WriteLine();
}
