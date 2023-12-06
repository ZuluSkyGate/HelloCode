using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"первое число '{firstNumber}' больше чем второе число '{secondNumber}'");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine($"первое число '{firstNumber}' меньше чем второе число '{secondNumber}'");
        }
        else
        {
            Console.WriteLine($"первое число '{firstNumber}' равно второму числу '{secondNumber}'");
        }
    }

    public static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        CompareNumbers(num1, num2);
    }
}
