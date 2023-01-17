using static System.Console;
Clear();

// Задача 36: Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
WriteLine($"Сумма элементов: стоящих на нечётных позициях: {SumOddPositionedElements(array)}");

WriteLine("=======UNIT TESTS=======");
int[] testArray1 = {3, 7, 23, 12};
int[] testArray2 = {-4, -6, 89, 6};

PrintArray(testArray1);
WriteLine($" -> {SumOddPositionedElements(testArray1)}");
PrintArray(testArray2);
WriteLine($" -> {SumOddPositionedElements(testArray2)}");

WriteLine("========КОНЕЦ========");

int SumOddPositionedElements(int[] inArray)
{
    int result = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if(i%2 != 0) result = result + inArray[i];
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