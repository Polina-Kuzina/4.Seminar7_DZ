// 49. Показать двумерный массив размером m×n, заполненный вещественными числами.
Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());
double[,] array = new double [m,n];
Console.WriteLine($"Массив из {m} строк и {n} столбцов:");
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().NextDouble();
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
