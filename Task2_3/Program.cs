// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка [10, 99] = {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра этого числа: {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра этого числа: {secondDigit}");
}