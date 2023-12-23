// Урок 5. Двумерные Массивы
// Задача 2: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random num = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = num.Next(num.Next(0, 50), num.Next(51, 100));
        }
    }
    return array;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write(massive[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Random num = new Random();
int row = num.Next(2, 11);
int col = num.Next(2, 11);
int[,] massive = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив: ");
System.Console.WriteLine("");
PrintArray(massive);
int tmp = 0;

for (int j = 0; j < massive.GetLength(1); j++)
{
    tmp = massive[0, j];
    massive[0, j] = massive[massive.GetLength(0) - 1, j];
    massive[massive.GetLength(0) - 1, j] = tmp;
}

System.Console.WriteLine();
System.Console.WriteLine($"Массив, в котором первая и последняя  строка ({massive.GetLength(0)})\nпоменялись местами:");
System.Console.WriteLine("");
PrintArray(massive);