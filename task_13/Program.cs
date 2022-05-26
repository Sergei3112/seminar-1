//  Напишите программу, которая задаёт массив целых чисел 
//  и выводит их на экран.
//  Размер массива определяется пользователем.

Console.Write($"Введите размер массива -> ");
int n = int.Parse(Console.ReadLine());
Random rang = new Random();
int[] Array = new int[n];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 100);
    Console.Write(Array[i] + " ");
}
