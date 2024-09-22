// int[,] matrix = new int[5,5]
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

int[,] = FilArray(3, 5, 1, 10);

int[,] FillArray(int colums, int rows, int minValue, maxValue);
{
    int[,] array = new int[rows, colums];
    Random run = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < colums; l++)
        {
            array[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Get.Length(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

void FindIndex(int[,] matrix)
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.Length(1); j++)
        {
            if(i % 2 == 0 && j %2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
