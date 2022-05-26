// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.

Console.Write("Введите натуральное число A -> ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число B -> ");
int B = int.Parse(Console.ReadLine());

int S = 1;
for (int i = 1; i <= B; i++)
{
    S *= A;
}
Console.WriteLine($"число A возведенное в натуральную степень B = {S}");