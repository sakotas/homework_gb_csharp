// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
Clear();

WriteLine("====UNIT TESTS====");
int[,] testArray = { { 1, 4, 7, 2 },
                     { 5, 9, 2, 3 },
                     { 8, 4, 2, 4 } };
PrintMultDimArray(testArray);
WriteLine();
ReverseLinesInArray(testArray);
PrintMultDimArray(testArray);

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

void ReverseLinesInArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        var tmp = inArray[inArray.GetLength(0)-1, i];
        inArray[inArray.GetLength(0)-1, i] = inArray[0, i];
        inArray[0, i] = tmp;
    }
}