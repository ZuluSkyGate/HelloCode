// Урок 6. Массивы и строки
// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.


char[,] GetRandom2DArrayOfChar()
{
    string line = "0123456789abcdefjhijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯЁ~@#$%^&!№;%:?*()_+/-.,\"<>";
    Random num = new Random();
    int row = num.Next(2, 11);
    int col = num.Next(2, 11);
    char[,] array = new char[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = line[num.Next(num.Next(0, line.Length))];
        }
    }
    return array;
}

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

string CreateString(char[,] array)
{
    string line = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            line += array[i, j];
        }
    }
    return line;
}

char[,] array = GetRandom2DArrayOfChar();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(CreateString(array));