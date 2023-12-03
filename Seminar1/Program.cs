// Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное на само себя).
// Например: 4 -> 16, -3 -> 9, -7 -> 49

System.Console.WriteLine("Enter number: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);

int square = num * num;
System.Console.WriteLine($" square = {square}");