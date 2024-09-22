// Урок №3. Массивы
// Задача №4 (не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться
// на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

System.Console.WriteLine("Введите натуральное число в диапазоне от 1 до 100 000: ");
string strNum = System.Console.ReadLine();
int size = strNum.Length;
int num = Convert.ToInt32(strNum);
int[] arr = new int[size];

for (int i = size - 1; i >= 0; i--)
{
    arr[i] = num % 10;
    num /= 10;
}
System.Console.WriteLine("Массив из цифр числа состоит из: ");

for (int i = 0; i < size; i++)
{
    System.Console.Write(arr[i] + " ");
}