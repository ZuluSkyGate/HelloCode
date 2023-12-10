// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10].
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

void FillArray(int[] collection)
void PrintArray(int[] col)
void PositiveArray(int[] pos)
{
    for (int i = 0; i < pos.Length; i++)
    {
        pos[i] *= -1;
    }
}



int list = new int[10];
FillArray(list);
PrintArray(list);
PositiveArray(list);

