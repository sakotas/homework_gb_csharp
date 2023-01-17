using static System.Console;
Clear();

// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
// [3, 3, 7, 1, 22, 5, 2, 2, 78, 2] -> 77

WriteLine("========НАЧАЛО========");
Write("Введите размер массива: ");
checkParsing(int.TryParse(ReadLine()!, out int size));

WriteLine("======================");
Write("Введите минимальное и максимальное значение элемента массива через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine("======================");
checkParsing(int.TryParse(parameters[0], out int min));
checkParsing(int.TryParse(parameters[1], out int max));

WriteLine("======================");
WriteLine($"Минимальное значение: {min}");
WriteLine($"Максимальное значение: {max}");
WriteLine($"Размер массива: {size}");

WriteLine("======================");
int[] array = GetArray(size, min, max);
WriteLine($"Создали новый массив:");
PrintArray(array);
WriteLine();

WriteLine("======================");
WriteLine($"Разница между максимальным и минимальным элементом массива: {differenceMinMaxValues(array)}");
WriteLine();
WriteLine("=======UNIT TESTS=======");
int[] testArray1 = { 3, 3, 7, 1, 22, 5, 2, 2, 78, 2 };

PrintArray(testArray1);
WriteLine($" -> {differenceMinMaxValues(testArray1)}");

WriteLine("========КОНЕЦ========");

int differenceMinMaxValues(int[] inArray)
{
    int result = findMax(inArray) - findMin(inArray);
    return result;

}

int findMax(int[] inArray)
{
    int max = min;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (max < inArray[i]) max = inArray[i];
    }

    return max;
}

int findMin(int[] inArray)
{
    int min = max;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (min > inArray[i]) min = inArray[i];
    }

    return min;
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

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }

    return result;
}
