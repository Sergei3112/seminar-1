// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = Convert.ToDouble(sum) / Convert.ToDouble(count);
        result += Math.Round(mean, 2).ToString() + " ";

    }
    return result;
}
int m = 3;
int n = 3;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));
