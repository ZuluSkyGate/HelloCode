﻿Console.WriteLine("Enter number: ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
if(num > 99 && num < 1000)
{
    int num2 = num % 10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Uncorrect number");
}