// Урок 5. Двумерные Массивы
// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            System.Console.Write(massive[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

Random num = new Random();
int row = num.Next(2, 11);
int col = num.Next(2, 11);
if (row == col) col += 1;
int[,] massive = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив: ");
PrintArray(massive);

int sum = 0, minSum = 0, resRow = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        sum += massive[i, j];
    }
    if (i == 0) minSum = sum;
    if (sum < minSum)
    {
        minSum = sum;
        resRow = i;
    }
    sum = 0;
}

System.Console.Write($"Минимальная сумма элементов находится в строке {resRow} и равна {minSum}");