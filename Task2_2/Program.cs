Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x > 0) && (y > 0))
{
    Console.Write("1");
}
if ((x < 0) && (y > 0))
{
    Console.Write("2");
}
if ((x < 0) && (y < 0))
{
    Console.Write("3");
}
if ((x > 0) && (y < 0))
{
    Console.Write("4");
}