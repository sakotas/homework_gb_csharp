// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;
Clear();

Write("input 5-digit number:");
if (!int.TryParse(ReadLine(), out int number))

{
    WriteLine("Error. Input number, not string");
    return;
}

if (number < 10000 || number > 99999)
{
    WriteLine($"Error. Insert 5-digit number");
    return;
}

else
{
    string n = number.ToString();
    if (n[0] == n[4] || n[1] == n[3])
    {
        Console.WriteLine($"Ваше число: {n} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {n} - НЕ палиндром.");
}
