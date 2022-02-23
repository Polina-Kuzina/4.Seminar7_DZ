// 53. В двумерном массиве показать позиции числа, 
// заданного пользователем, или указать, что такого элемента нет.
Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());

int[,] array = new int [m,n];
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,100);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Ведите число для поиска");
int x = int.Parse(Console.ReadLine());
int count = 0;
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        if(array[i,j] == x) 
        {
            Console.WriteLine($"число {x} на позиции [{i},{j}]");
            count++;
        }
    }
}
if(count == 0) Console.WriteLine("в массиве нет числа " + x);