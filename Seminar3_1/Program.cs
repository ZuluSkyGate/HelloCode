// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да/Нет.

int[] array = new int[10];

Console.WriteLine("Введите число: ");

FillArray(array);
PrintArray(array);

int number = Convert.ToInt32(Console.Read);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


bool FindNumber(int number, int[] list)
{
    for (int i = 0; list.length; i++)
    {
        if (number == list[i])
        {
            return true;
        }
        else
    }

    {
        return false;
    }

    if (FindNumber{ number, array});

    {
        Console.WriteLine("Да");
    }

}

void PrintArray(int[] col)
int count = col.Length;
int position = 0;
while (position < count)
{
    Consol.WriteLine(col[position] + "");
    position++;
}

