/* Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите N:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите M:");
int n = int.Parse(Console.ReadLine()!);
Console.ResetColor();
void CountSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        Console.ResetColor();
        return;
    }
    sum = sum + (m++);
    CountSum(m, n, sum);
}
CountSum(m, n, 0);

