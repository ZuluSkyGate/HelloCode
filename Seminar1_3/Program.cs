System.Console.WriteLine("Enter number: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int numStart = num * -1;
while (numStart <= num)
    {
        Console.WriteLine(numStart);
        ++numStart;
    }    