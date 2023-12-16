// Урок №3. Массивы.
// Задача №1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
Random num = new Random();
int count = 0;
string separator = ", ";

for (int i = 0; i <= 9; i ++)
{
    array[i] = num.Next(1, 100);
    if (i == 9) separator = "";
    System.Console.Write($"{array[i]}{separator}");
    if (array[i] >= 20 && array[i] <= 90) count ++;
}

System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90], равно {count}");