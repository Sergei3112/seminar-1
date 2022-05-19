// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа

Console.WriteLine("Задача 10");

Console.WriteLine("Введите трехзначное число.");

while (true)
{
    string input = Console.ReadLine();

    if (!input.Equals("exit"))

        Console.WriteLine("{0}->{1}", input, input[1]);

    else
        break;
}
