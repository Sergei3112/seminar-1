// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее

Console.WriteLine();
int a, b;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());

var Chto0 = a > b;
var Chto1 = a == b;
var Chto2 = a < b;

if (Chto0)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else if (Chto1)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
    Console.WriteLine(value: $"Число {b} больше чем {a}");
}


