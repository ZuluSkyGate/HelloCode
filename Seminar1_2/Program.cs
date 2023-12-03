System.Console.WriteLine("Enter week day: ");
string week_day = Console.ReadLine();
int num_week_day = Convert.ToInt32(week_day);
if(num_week_day == 1)
{
    Console.WriteLine("Monday");
}
else if (num_week_day == 2)
{
        Console.WriteLine("Tuesday");
}
else if (num_week_day == 3)
{
        Console.WriteLine("Wednesday");
}
else if (num_week_day == 4)
{
        Console.WriteLine("Thursday");
}
else if (num_week_day == 5)
{
        Console.WriteLine("Friday");
}
else if (num_week_day == 6)
{
        Console.WriteLine("Saturday");
}
else if (num_week_day == 7)
{
        Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Uncorrect number");
}