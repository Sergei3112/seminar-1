//  Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество четных чисел

Console.Write($"Введите размер массива -> ");
int n = int.Parse(Console.ReadLine());

int[] Array = new int[n];
int countEven = 0;

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 999);
    Console.Write(Array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < Array.Length; j++)
{
    if (Array[j] % 2 == 0) countEven = countEven + 1;
}
Console.Write($"Четные числа из массива-> {countEven}");