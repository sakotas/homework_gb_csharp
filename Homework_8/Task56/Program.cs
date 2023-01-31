// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

WriteLine("====UNIT TESTS====");
int[,] testArray = { { 1, 4, 7, 2 },
                     { 5, 9, 2, 3 },
                     { 8, 4, 2, 4 },
                     { 5, 2, 6, 7 } };
PrintMultDimArray(testArray);
WriteLine();
WriteLine($"Строка с наименьшей суммой элементов: {CheckMinSumRow(testArray)}");


int CheckMinSumRow(int[,] inArray)
{
    int minSum = 0;
    int minSumIndex = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum += inArray[0, j];
    }

    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
    }
    return minSumIndex +1;
}

void PrintMultDimArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($" {inArray[i, j]}");
        }
        WriteLine();
    }
}


