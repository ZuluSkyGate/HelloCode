// Урок 5. Двумерные Массивы
// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray (int rows, int columns)
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

void PrintArray (int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write(massive[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

Random num = new Random();
int row = num.Next(2, 11);
int col = num.Next(2, 11);
int[,] massive = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив:");
PrintArray(massive);
System.Console.Write("Введите через пробел координаты чисел из массива (строка столбец): ");
string indexes = System.Console.ReadLine();
int rowElement = Convert.ToInt32(indexes.Split()[0]);
int colElement = Convert.ToInt32(indexes.Split()[1]);

if (rowElement >= 0 && rowElement < row &&
    colElement >= 0 && colElement < col)
System.Console.WriteLine($"Координаты[{rowElement}, {colElement}] = {massive[rowElement, colElement]}");
else
System.Console.WriteLine($"Введённые координаты за пределами массива!!!");