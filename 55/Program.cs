// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
int sum = 0;
for(int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        sum = sum + array[j,i];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i} = {sum/m}");
    sum = 0;
}

