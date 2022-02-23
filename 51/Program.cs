// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n.
Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int [m,n];
Console.WriteLine($"Массив из {m} строк и {n} столбцов:");
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = i+j;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
