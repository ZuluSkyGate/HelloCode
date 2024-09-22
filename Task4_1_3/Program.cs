// Урок 6. Массивы и строки
// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string GetString()
{
    Console.WriteLine("Введите любую строку, а я проверю,\nявляется ли она палиндромом: ");
    Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
    string line = Console.ReadLine();
    if (line == string.Empty)
    {
        Console.WriteLine("Ладно, тогда выберу сам!");
        string[] numArray =
        {
            "А роза упала на лапу Азора",
            "123 456 lI 654 321",
            "123 456 654 321",
            "aBcD1ef!",
            "шалаш",
            "55655"
        };
        Random num = new Random();
        int index = num.Next(0, numArray.Length - 1);
        return numArray[index];
    }
    return num;
}

bool IsPalindrom(string num)
{
    string tmpNum = string.Join("", num.Split()).ToLower();
    for (int i = 0; i < tmpNum.Length / 2; i++)
    {
        if (tmpNum[i] != tmpNum[tmpNum.Length - 1 - i])
            return false;
    }
    return true;
}

string num = GetString();
if (IsPalindrom(num)) System.Console.WriteLine($"Строка \"{num}\" - палиндром!");
else System.Console.WriteLine(($"Строка {num} - НЕ палиндром!"));