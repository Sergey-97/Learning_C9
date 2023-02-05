/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите положительное число от 1:");
int n = int.Parse(Console.ReadLine()!);
Console.ResetColor();
int m = 1;
Console.ForegroundColor = ConsoleColor.Red;
if (n < 1)
{

    Console.WriteLine("Вы ввели не положительное число");
    Console.ResetColor();
    return;
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(num(n, m));

int num(int n, int m)
{
    if (n == m)
        return n;
    else

        Console.Write($"{num(n, m + 1)}, ");
    return m;
}

Console.ResetColor();

