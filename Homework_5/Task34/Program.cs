using static System.Console;
Clear();

// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

WriteLine("========НАЧАЛО========");
Write("Введите размер массива: ");
checkParsing(int.TryParse(ReadLine()!, out int number));

WriteLine("======================");
int[] array = GetArray(number);
WriteLine("Созданный массив:");
PrintArray(array);
WriteLine();
WriteLine("======================");
WriteLine($"Количество четных чисел в массиве: {CalculateEvenNumbers(array)}");
WriteLine("========КОНЕЦ========");

int[] GetArray(int size)
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }

    return result;
}

int CalculateEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    return count;
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