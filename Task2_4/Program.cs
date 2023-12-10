// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
System.Console.Write(i + ", ");
}