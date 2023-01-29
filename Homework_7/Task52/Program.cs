using static System.Console;
Clear();

// Задача 52. Напишите программу реализующую методы, 
// формирования двумерного массива и массива средних 
// арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

WriteLine("Введите кол-во строк и столбцов через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"Кол-во строк: {int.Parse(parameters[0])}");
WriteLine($"Кол-во столбцов: {int.Parse(parameters[1])}");

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);

double[] Average = GetAverages(array);
Write("Среднее арифметическое каждого столбца: [");
for(int i =0; i < Average.Length -1; i ++)
{
    Write($"{Math.Round(Average[i], 1)}, ");
}
WriteLine($"{Math.Round(Average[Average.Length-1])}]");

WriteLine();

WriteLine();
WriteLine("====UNIT TEST====");
int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintMatrixArray(testArray);
double[] testAverage = GetAverages(testArray);
Write("Среднее арифметическое каждого столбца: [");
for(int i =0; i < testAverage.Length -1; i ++)
{
    Write($"{Math.Round(testAverage[i], 1)}, ");
}
WriteLine($"{Math.Round(testAverage[testAverage.Length-1])}]");

double[] GetAverages(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            result[j] += inArray[i, j];
        }
        result[j] /= inArray.GetLength(0);
    }

    return result;
}

int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }

    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],2} ");
        }
        WriteLine();
    }
}