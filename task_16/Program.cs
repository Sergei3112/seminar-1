// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write($"Введите размер массива -> ");
int n = int.Parse(Console.ReadLine());
int[] Array = new int[n];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 100);
    Console.Write(Array[i] + " ");
}
int max = Array[0];
int min = Array[0];
for (int j = 0; j < Array.Length; j++)
{
    if (Array[j] > max) max = Array[j];
    if (Array[j] < min) min = Array[j];
}
Console.WriteLine();
Console.Write($"Разница между max и min значением -> {max - min}");