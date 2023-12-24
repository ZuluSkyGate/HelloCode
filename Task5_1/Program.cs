// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void num(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{ m}, ");
    }
    num(m + 1, n);

}
num(m, n);