// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.WriteLine("Задача 15 ");

Console.Write(" введите число ");

bool palindrome = true;
int x = int.Parse(Console.ReadLine());

if (x < 10000 || x > 99999)

    Console.WriteLine("ошибка!!! номер должен быть пятизначным...");

int c = x.ToString().Length - 1;
string b = x.ToString();

for (int i = 0; i < c; i++)

    if (b[i] != b[c - i])
        palindrome = false;
if (palindrome == true)
    Console.Write(" число является палиндромом ");

else

    Console.Write(" число не является палиндромом ");
Console.ReadKey();
