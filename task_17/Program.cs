// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Введите числа: ");

int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int numbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine(numbers(array));

