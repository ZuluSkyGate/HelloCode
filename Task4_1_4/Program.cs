﻿// Урок 6. Массивы и строки
// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string GetString()
{
    System.Console.WriteLine("Введите любую строку, а я проверю,\nявляется ли она палиндромом: ");
    Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
    string st = Console.ReadLine();
    if (st == string.Empty)
    {
        System.Console.WriteLine("Ладно, тогда выберу сам!");
        string[] stArray =
        {
            "А роза упала на лапу Азора",
            "123 456 lI 654 321",
            "123 456 654 321",
            "aBcD1ef!",
            "шалаш",
            "55655"
        };
        Random rnd = new Random();
        int index = rnd.Next(0, stArray.Length - 1);
        return stArray[index];
    }
    return st;
}

bool IsPalindrom(string st)
{
    string tempSt = string.Join("", st.Split()).ToLower();
    for (int i = 0; i < tempSt.Length / 2; i++)
    {
        if (tempSt[i] != tempSt[tempSt.Length - 1 - i])
            return false;
    }
    return true;
}

string st = GetString();
if (IsPalindrom(st)) System.Console.WriteLine($"Строка \"{st}\" - палиндром!");
else System.Console.WriteLine(($"Строка {st} - НЕ палиндром!"));