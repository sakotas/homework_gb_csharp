using static System.Console;
Clear();

// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

WriteLine("========НАЧАЛО========");
Write("Введите числа А и Б через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine("======================");
checkParsing(int.TryParse(parameters[0], out int A));
checkParsing(int.TryParse(parameters[1], out int B));

WriteLine("======================");
WriteLine($"Число А: {A}");
WriteLine($"Число Б: {B}");

WriteLine("======================");
WriteLine($"Число {A}, возведенное в натуральную степень {B}, дает {numbersPower(A, B)}");
WriteLine("========КОНЕЦ========");

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

int numbersPower(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}