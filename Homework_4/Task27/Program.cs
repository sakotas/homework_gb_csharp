using static System.Console;
Clear();

// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

WriteLine("========НАЧАЛО========");
Write("Введите число: ");
checkParsing(int.TryParse(ReadLine()!, out int number));

WriteLine("======================");
WriteLine($"Сумма цифр в числе: {digitSum(number)}");
WriteLine("========КОНЕЦ========");

int digitSum(int i)
{
    int result = 0;
    int n = i;
    while (n > 0)
    {
        result = result + n % 10;
        n = n / 10;
    }

    return result;
}

void checkParsing(bool isParse)
{
    if (!isParse)
    {
        Console.WriteLine($"Проверка не пройдена - НЕ ЧИСЛО!");
    }
    else
    {
        Console.WriteLine($"Проверка пройдена");
    }
}