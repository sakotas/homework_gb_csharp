using static System.Console;
Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

WriteLine("========НАЧАЛО========");
Write("Введите числа через пробел: ");
string[] numbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintNumbersAndAmountPosNumbers(numbers);

WriteLine();
WriteLine("=======UNIT TESTS=======");
string[] testArray1 = {"0", "7", "8", "-2", "-2"};
string[] testArray2 = {"1", "-7", "567", "89", "223"};

PrintNumbersAndAmountPosNumbers(testArray1);
PrintNumbersAndAmountPosNumbers(testArray2);
WriteLine("========КОНЕЦ========");

void PrintNumbersAndAmountPosNumbers(string[] inArray)
{
    PrintNumbers(inArray);
    Write(" -> ");
    WriteLine(PositiveNumbersAmount(inArray));
}

int PositiveNumbersAmount(string[] inArray)
{
    int result = 0;

    for (int i = 0; i <inArray.Length; i++)
    {
        if(int.Parse(inArray[i]) > 0) result++;
    }
    return result;
}

void PrintNumbers(string[] inArray)
{
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}");
}