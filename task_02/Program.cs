//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

    Console.WriteLine("Введите первое число - ");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число - ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(value: "Введите третье число - ");
    double c = double.Parse(s: Console.ReadLine());
    if (a < b) a = b;
    if (a >= c)
    {
    }
    else
        a = c;
    Console.WriteLine("Max = {0}", a);
    Console.ReadKey();
