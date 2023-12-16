// Урок №3. Массивы.
// Задача №2: Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
Random num = new Random();
int count = 0;
string separator = ", ";
for (int i = 0; i <= 9; i ++)
{
    array[i] = num.Next(1, 100);
    if (i == 9) separator = "";
    System.Console.Write($"{array[i]}{separator}");
    if (array[i] % 2 == 0) count ++;
}

System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных элементов массива равно: {count}"); 