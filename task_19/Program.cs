// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],0:F1} ");
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 4;
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
