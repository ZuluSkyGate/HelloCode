System.Console.WriteLine("Enter number_1: ");
string str_1 = Console.ReadLine();
int num_1 = Convert.ToInt32(str_1);
System.Console.WriteLine("Enter number_2: ");
string str_2 = Console.ReadLine();
int num_2 = Convert.ToInt32(str_2);
if(num_2 * num_2 == num_1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}