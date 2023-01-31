// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

WriteLine("====UNIT TESTS====");
int[,] testArray1 = { { 2, 4},
                      { 3, 2}};

int[,] testArray2 = { { 3, 4},
                      { 3, 3}};
                    
PrintMultDimArray(testArray1);
WriteLine();
PrintMultDimArray(testArray2);

WriteLine();

PrintMultDimArray(ProductMatrix(testArray1, testArray2));

int[,] ProductMatrix(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray1.GetLength(1); k++)
            {
                result[i, j] += inArray1[i,k]*inArray2[k,j];
            }
        }
    }
    return result;
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


