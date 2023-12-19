// Обратная строка: Создайте программу, которая принимает строку
// и выводит её в обратном порядке. Например, "hello" станет "olleh".

string GetString()
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();
    return str;
}
string ReversString(string str)
{
    string result = String.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
    {
        result += str[i];
    }
    return result;
}
string str = GetString();
string rev = ReversString(str);

Console.WriteLine(rev);




