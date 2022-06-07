// Напишите программу, которая найдёт точкупересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем

Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
string X(int k1, int k2, int b1, int b2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}
Console.WriteLine(X(k1, k2, b1, b2));

