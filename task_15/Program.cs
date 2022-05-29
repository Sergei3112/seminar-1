//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите размер массива -> ");
int n = int.Parse(Console.ReadLine());
int[] Array = new int[n];
int count = 0;

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 100);
    Console.Write(Array[i] + " ");
}
for (int j = 0; j < Array.Length; j++)
{
    if (j % 2 == 1) count = count + Array[j];
}
Console.WriteLine();
Console.Write($"Сумма чисел  на нечетной позиции в массиве -> {count} ");
