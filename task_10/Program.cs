// Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int i = 1;

Console.WriteLine("Введите число N: ");

int n = int.Parse(Console.ReadLine());

Console.WriteLine("Число -> Куб");

for (i = 1; i <= n; i++)
{
    Console.WriteLine(i + "\t" + i * i * i);
}
