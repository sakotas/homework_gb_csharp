using static System.Console;
Clear();

// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

WriteLine("Введите размер матрицы через пробел: ");
int[] intParams=Array.ConvertAll(ReadLine()!.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries),int.Parse);

WriteLine($"m = {intParams[0]}, n = {intParams[1]}");
double[,] array = GetRandomFloatMatrixArray(intParams[0], intParams[1]); 
PrintMatrixArray(array);

double[,] GetRandomFloatMatrixArray(int rows, int columns)
{
    Random random = new Random();
    
    double[,] resultArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = Math.Round((random.Next(-10,10) + random.NextDouble()),1);
        }

    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 4} ");
        }
        WriteLine();
    }
}